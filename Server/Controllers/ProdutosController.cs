
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Interfaces;

namespace Server.Controllers;

[ApiController]
[Route("api/")]
public class ProdutosController : ControllerBase
{
    private readonly IProdutosService _iProdutosService;

    public ProdutosController(IProdutosService iProdutosService)
    {
        _iProdutosService = iProdutosService;
    }

    [HttpGet("getprodutos")]
    public async Task<ActionResult<List<ProdutosDto>>> GetAll()
    {
        var recommendations = await _iProdutosService.GetProdutosAsync();
        return Ok(recommendations);
    }
}

