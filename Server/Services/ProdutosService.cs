using Shared.DTOs;
using Shared.Interfaces;

namespace Server.Services;

public class ProdutosService : IProdutosService
{
    public Task<List<ProdutosDto>> GetProdutosAsync()
    {
        var produtos = new List<ProdutosDto>
        {
            new ProdutosDto { Id = 1, Produto = "Produto A", Descricao = "Descrição do Produto A", Valor = 10.0m, Obs= "Sem observações A" },
            new ProdutosDto { Id = 2, Produto = "Produto B", Descricao = "Descrição do Produto B", Valor = 100.0m, Obs= "Sem observações B" },
            new ProdutosDto { Id = 3, Produto = "Produto C", Descricao = "Descrição do Produto C", Valor = 1000.0m, Obs= "Sem observações C" },
        };

        return Task.FromResult(produtos);
    }

    public Task PutProdutosAsync(ProdutosDto dto)
    {
        return Task.CompletedTask;
    }
}

