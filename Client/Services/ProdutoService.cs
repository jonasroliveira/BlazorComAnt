using System.Net.Http.Json;
using Shared.DTOs;
using Shared.Interfaces;

namespace Client.Services;

public class ProdutoService : IProdutoService
{
    private readonly HttpClient _httpClient;

    public ProdutoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ProdutoDto>> GetProdutosAsync()
    {
        var response = await _httpClient.GetAsync("api/getprodutos");

        return await  response.Content.ReadFromJsonAsync<List<ProdutoDto>>() ?? new List<ProdutoDto>();
    }

    public async Task PutProdutosAsync(ProdutoDto dto)
    {
        await _httpClient.PutAsJsonAsync("api/putprodutos", dto);
    }
}