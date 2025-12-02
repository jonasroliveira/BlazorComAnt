using Shared.DTOs;

namespace Shared.Interfaces;
public interface IProdutosService
{
    Task<List<ProdutosDto>> GetProdutosAsync();
    Task PutProdutosAsync(ProdutosDto dto);
}