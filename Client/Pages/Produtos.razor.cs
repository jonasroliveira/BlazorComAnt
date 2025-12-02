using Microsoft.AspNetCore.Components;
using Shared.DTOs;
using Shared.Interfaces;

namespace Client.Pages;

public partial class Produtos
{
    private bool spinner = false;
    private bool visibleDrawer = false;
    private string inputValueObs = string.Empty;

    private Dictionary<string, object> produto = new();

    private List<ProdutosDto> produtos = new();

    [Inject]
    private IProdutosService iProdutosService { get; set; } = null!;

    override protected async Task OnInitializedAsync()
    {
        try
        {
            spinner = true;
            produtos = await iProdutosService.GetProdutosAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            spinner = false;
            StateHasChanged();
        }
    }

    private void SelecionouTableID(ProdutosDto proDto)
    {
        produto.Clear();
        inputValueObs = string.Empty;

        produto.Add("Id", proDto.Id);
        produto.Add("Produto", proDto.Produto);
        produto.Add("Descrição", proDto.Descricao);
        produto.Add("Valor", proDto.Valor);
        produto.Add("Obs.", proDto.Obs);

        visibleDrawer = true;
    }

    private async Task SalvarObsAsync()
    {
        try
        {
            var dto = new ProdutosDto
            {
                Id = (int)produto["Id"],
                Produto = (string)produto["Produto"],
                Descricao = (string)produto["Descrição"],
                Valor = (decimal)produto["Valor"],
                Obs = inputValueObs
            };

            produtos.First(p => p.Id == dto.Id).Obs = inputValueObs;

            //await iProdutosService.PutProdutosAsync(dto);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            visibleDrawer = false;
            StateHasChanged();
        }
    }
}
