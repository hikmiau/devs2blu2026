using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.models;

namespace MinhaPrimeiraApi.controllers;

[ApiController]
[Route("/api/[controller]")]
public class ProdutoController : ControllerBase
{
    private static List<Produto> produtos = [
        new() {Id = 1, Nome = "Teclado", Preco = 10.0m},
        new() {Id = 2, Nome = "Mouse", Preco = 20.0m},
        new() {Id = 3, Nome = "Monitor", Preco = 30.0m}
    ];
    private static int idCounter = 3;

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> GetAll()
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
    public ActionResult<Produto> Add([FromBody] Produto produto)
    {
        idCounter++;
        produto.Id = idCounter;
        produtos.Add(produto);
        return produto;
    }
    [HttpDelete("{id:int}")]
    public ActionResult<Produto> Delete(int id)
    {
        Produto produto = produtos.FirstOrDefault(p => p.Id == id);
        if (produto is null) return NotFound();
        produtos.Remove(produto);
        return Ok();
    }

    [HttpPut("{id:int}")]
    public ActionResult<Produto> Update(int id, [FromBody] Produto alterado)
    {
        Produto produtoExistente = produtos.FirstOrDefault(p => p.Id == id);
        if (produtoExistente is null) return NotFound();
        produtoExistente.Nome = alterado.Nome;
        produtoExistente.Preco = alterado.Preco;
        
        return Ok(produtoExistente);
    }
}