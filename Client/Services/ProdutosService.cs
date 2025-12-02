using System.Net.Http.Json;
using Shared.DTOs;
using Shared.Interfaces;

namespace Client.Services;

public class ProdutosService : IProdutosService
{
    private readonly HttpClient _httpClient;

    public ProdutosService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ProdutosDto>> GetProdutosAsync()
    {
        var response = await _httpClient.GetAsync("api/getprodutos");

        return await  response.Content.ReadFromJsonAsync<List<ProdutosDto>>() ?? new List<ProdutosDto>();
    }

    public Task PutProdutosAsync(ProdutosDto dto)
    {
        throw new NotImplementedException();
    }
}