using Microsoft.AspNetCore.Mvc;
using Api0109.DTOs;
using Api0109.Services;

namespace Api0109.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly IProdutoService _service;

    public ProdutosController(IProdutoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] ProdutoFilterDto filtro)
    {
        var produtos = await _service.ListarProdutosAsync(filtro);
        return Ok(produtos);
    }
}
