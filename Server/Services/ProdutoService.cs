using Shared.DTOs;
using Shared.Interfaces;

namespace Server.Services;

public class ProdutoService : IProdutoService
{
    private readonly HttpClient _httpClient;

    public ProdutoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress ??= new Uri("http://localhost:5146/api/produto");
    }

    public async Task<List<ProdutoDto>> GetProdutosAsync()
    {
        var response = await _httpClient.GetAsync("");
        response.EnsureSuccessStatusCode();
        var produtos = await response.Content.ReadFromJsonAsync<List<ProdutoDto>>();
        return produtos ?? new List<ProdutoDto>();
    }

    public async Task PutProdutosAsync(ProdutoDto dto)
    {
        var response = await _httpClient.PutAsJsonAsync("", dto);
        response.EnsureSuccessStatusCode();
    }
}

