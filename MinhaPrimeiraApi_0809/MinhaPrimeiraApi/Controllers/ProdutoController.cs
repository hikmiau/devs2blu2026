using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.DTOs;
using MinhaPrimeiraApi.Services;

namespace MinhaPrimeiraApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoService _service;

    public ProdutoController(IProdutoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<ProdutoResponse>>> Listar([FromQuery] ProdutoFiltro filtro, CancellationToken ct)
        => Ok(await _service.ListarAsync(filtro, ct));

    [HttpGet("{id:int}", Name = "ObterProduto")]
    public async Task<ActionResult<ProdutoResponse>> ObterPorId(int id, CancellationToken ct)
    {
        var produto = await _service.ObterPorIdAsync(id, ct);

        if (produto is null)
            return NotFound();

        return Ok(produto);
    }

    [HttpPost]
    public async Task<ActionResult<ProdutoResponse>> Criar([FromBody] ProdutoRequest request, CancellationToken ct)
    {
        var criado = await _service.CriarAsync(request, ct);
        return CreatedAtRoute(nameof(ObterPorId), new { id = criado.Id }, criado);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<ProdutoResponse>> Atualizar(int id, [FromBody] ProdutoRequest request, CancellationToken ct)
    {
        var atualizado = await _service.AtualizarAsync(id, request, ct);

        if (atualizado is null)
            return NotFound();

        return Ok(atualizado);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Remover(int id, CancellationToken ct)
    {
        var removido = await _service.RemoverAsync(id, ct);

        if (!removido)
            return NotFound();

        return NoContent();
    }
}