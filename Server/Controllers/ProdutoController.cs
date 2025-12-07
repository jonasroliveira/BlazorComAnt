
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Interfaces;

namespace Server.Controllers;

[ApiController]
[Route("api/")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoService _iProdutosService;

    public ProdutoController(IProdutoService iProdutosService)
    {
        _iProdutosService = iProdutosService;
    }

    [HttpGet("getprodutos")]
    public async Task<ActionResult<List<ProdutoDto>>> GetAll()
    {
        var recommendations = await _iProdutosService.GetProdutosAsync();
        return Ok(recommendations);
    }

    [HttpPut("putprodutos")]
    public async Task<IActionResult> PutProdutos([FromBody] ProdutoDto dto)
    {
        await _iProdutosService.PutProdutosAsync(dto);
        return NoContent();
    }
}

