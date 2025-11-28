
namespace Client.Pages;

public partial class Produtos
{
    private bool Visible;
    private string inputValue = string.Empty;

    private Dictionary<string, object> produto = new()
    {
        { "Produto", "Produto" },
        { "Valor", 99.99 },
        { "Qtd.", "3" },
        { "Observação", "OBS" }
    };
}