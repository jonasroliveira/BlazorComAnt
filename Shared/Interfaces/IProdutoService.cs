using Shared.DTOs;

namespace Shared.Interfaces;
public interface IProdutoService
{
    Task<List<ProdutoDto>> GetProdutosAsync();
    Task PutProdutosAsync(ProdutoDto dto);
}