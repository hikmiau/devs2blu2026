using Api02.Models;
using Api02.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _service;

        public LivroController(ILivroService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<List<Livro>>> Listar()
        {
            return Ok(await _service.ListarAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Livro>> BuscarPorId(int id)
        {
            var livro = await _service.ObterPorIdAsync(id);
            return livro is null ? NotFound() : Ok(livro);
        }
        [HttpPost]
        public async Task<ActionResult<Livro>> Criar(Livro livro)
        {
            var criado = await _service.CriarAsync(livro);
            return CreatedAtAction(nameof(BuscarPorId), new { id = criado.id }, criado);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] Livro livro)
        {
            var ok = await _service.AtualizarAsync(id, livro);
            return ok ? NoContent() : NotFound();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Remover(int id)
        {
            var ok = await _service.RemoverAsync(id);
            return ok ? NoContent() : NotFound();
        }
    }
}
