using LivrosApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Livros",
        Version = "v1",
        Description = "Controle de livros (cadastro, consulta, atualização e remoção). Dados mantidos em memória."
    });
});
builder.Services.AddSingleton<LivroStore>();
builder.Services.AddCors(o => o.AddDefaultPolicy(p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

app.UseCors();

// O Copilot Studio precisa do bloco "servers" com a URL pública (https) para chamar a API.
app.UseSwagger(c => c.PreSerializeFilters.Add((doc, req) =>
    doc.Servers = new List<OpenApiServer> { new() { Url = $"https://{req.Host.Value}" } }));
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Livros v1"));

app.MapGet("/", () => Results.Redirect("/swagger")).ExcludeFromDescription();

var livros = app.MapGroup("/livros").WithTags("Livros");

livros.MapGet("/", (
        [FromQuery] string? titulo, [FromQuery] string? autor, [FromQuery] string? genero,
        [FromQuery] string? editora, [FromQuery] bool? disponivel, LivroStore store) =>
        Results.Ok(store.Listar(titulo, autor, genero, editora, disponivel)))
    .WithName("ListarLivros")
    .WithSummary("Lista e busca livros")
    .WithDescription("Retorna os livros cadastrados. Todos os filtros são opcionais e combináveis: título, autor, gênero e editora (busca parcial, sem diferenciar maiúsculas) e disponível (true/false).")
    .Produces<IEnumerable<Livro>>();

livros.MapGet("/{isbn}", (string isbn, LivroStore store) =>
    {
        var livro = store.Obter(IsbnValidator.Normalizar(isbn));
        return livro is null
            ? Results.NotFound(new ErroResposta($"Livro com ISBN {isbn} não encontrado."))
            : Results.Ok(livro);
    })
    .WithName("ObterLivroPorIsbn")
    .WithSummary("Obtém um livro pelo ISBN")
    .WithDescription("Busca um livro específico pelo ISBN (10 ou 13 dígitos, com ou sem hifens).")
    .Produces<Livro>()
    .Produces<ErroResposta>(StatusCodes.Status404NotFound);

livros.MapPost("/", (Livro livro, LivroStore store) =>
    {
        livro.Isbn = IsbnValidator.Normalizar(livro.Isbn);
        var erro = Validar(livro);
        if (erro is not null) return Results.BadRequest(new ErroResposta(erro));

        return store.Adicionar(livro)
            ? Results.Created($"/livros/{livro.Isbn}", livro)
            : Results.Conflict(new ErroResposta($"Já existe um livro com o ISBN {livro.Isbn}."));
    })
    .WithName("CadastrarLivro")
    .WithSummary("Cadastra um novo livro")
    .WithDescription("Cria um livro. O ISBN é obrigatório, deve ser válido (ISBN-10 ou ISBN-13) e único. Disponivel e DataCadastro são calculados pela API.")
    .Produces<Livro>(StatusCodes.Status201Created)
    .Produces<ErroResposta>(StatusCodes.Status400BadRequest)
    .Produces<ErroResposta>(StatusCodes.Status409Conflict);

livros.MapPut("/{isbn}", (string isbn, Livro livro, LivroStore store) =>
    {
        var chave = IsbnValidator.Normalizar(isbn);
        livro.Isbn = chave;
        var erro = Validar(livro);
        if (erro is not null) return Results.BadRequest(new ErroResposta(erro));

        return store.Atualizar(chave, livro)
            ? Results.Ok(store.Obter(chave))
            : Results.NotFound(new ErroResposta($"Livro com ISBN {isbn} não encontrado."));
    })
    .WithName("AtualizarLivro")
    .WithSummary("Atualiza um livro existente")
    .WithDescription("Substitui todos os dados do livro identificado pelo ISBN informado na URL. O ISBN não pode ser alterado.")
    .Produces<Livro>()
    .Produces<ErroResposta>(StatusCodes.Status400BadRequest)
    .Produces<ErroResposta>(StatusCodes.Status404NotFound);

livros.MapDelete("/{isbn}", (string isbn, LivroStore store) =>
        store.Remover(IsbnValidator.Normalizar(isbn))
            ? Results.NoContent()
            : Results.NotFound(new ErroResposta($"Livro com ISBN {isbn} não encontrado.")))
    .WithName("RemoverLivro")
    .WithSummary("Remove um livro")
    .WithDescription("Remove definitivamente o livro identificado pelo ISBN.")
    .Produces(StatusCodes.Status204NoContent)
    .Produces<ErroResposta>(StatusCodes.Status404NotFound);

app.Run();

static string? Validar(Livro l)
{
    if (!IsbnValidator.EhValido(l.Isbn)) return "ISBN inválido. Informe um ISBN-10 ou ISBN-13 válido.";
    if (string.IsNullOrWhiteSpace(l.Titulo)) return "O título é obrigatório.";
    if (l.Autores.Count == 0 || l.Autores.Any(string.IsNullOrWhiteSpace)) return "Informe ao menos um autor.";
    if (string.IsNullOrWhiteSpace(l.Editora)) return "A editora é obrigatória.";
    if (l.AnoPublicacao < 1450 || l.AnoPublicacao > DateTime.UtcNow.Year + 1) return "Ano de publicação inválido.";
    if (l.Edicao < 1) return "A edição deve ser maior ou igual a 1.";
    if (l.NumeroPaginas < 1) return "O número de páginas deve ser maior que zero.";
    if (l.Preco < 0) return "O preço não pode ser negativo.";
    if (l.Estoque < 0) return "O estoque não pode ser negativo.";
    return null;
}
