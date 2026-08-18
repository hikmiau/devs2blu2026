using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProdutoController : ControllerBase
{
    [HttpGet]
    public string GetTexto() =>
        "Olá, mundo!";
}