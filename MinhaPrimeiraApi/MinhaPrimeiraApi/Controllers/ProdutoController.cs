using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Controllers;

[ApiController]
[Route("/api/[controller]")]

public class ProdutoController : ControllerBase
{
    private static List<Produto> produtos = [new(){Id = 1, Nome = "Produto 1", Preco = 10.0m},
                                             new(){Id = 2, Nome = "Produto 2", Preco = 20.0m},
                                             new(){Id = 3, Nome = "Produto 3", Preco = 30.0m}];

    public static int idCounter;
    [HttpGet]
    public ActionResult<IEnumerable<Produto>> Get()
    {
        return produtos;
    }

    [HttpGet("{id:int}")]
    public ActionResult<Produto> GetById(int id)
    {
        Console.WriteLine("ID: "+id);
        Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            return produto is null ? NotFound() : Ok(produto);
    }
    

    [HttpPost]
    public ActionResult<Produto> Add([FromBody]Produto produto)
    {
        idCounter++;
        produto.Id = idCounter;
        produtos.Add(produto);
        return produto;
    }

    [HttpDelete(("{id:int}"))]
    public ActionResult<Produto> Delete(int id)
    {
        Produto produto = produtos.FirstOrDefault(p => p.Id == id);
        if (produto is null) return NotFound();
        produtos.Remove(produto);
        return Ok("Sim");
    }

    [HttpPut("{id:int}")]
    public ActionResult<Produto> Update(int id, [FromBody] Produto produto)
    {
        Produto produtoExistente = produtos.FirstOrDefault(p => p.Id == id);
        if (produtoExistente is null) return NotFound();
        produtoExistente.Nome = produto.Nome;
        produtoExistente.Preco = produto.Preco;
        return Ok(produtoExistente);
    }
}
