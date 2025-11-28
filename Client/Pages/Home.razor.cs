namespace Client.Pages;

public partial class Home
{
    private bool Visible;
    private string inputValue = string.Empty;

    private Dictionary<string, object> produto = new()
    {
        { "Nome", "Citizen" },
        { "Idade", 25 },
        { "Profissão", "Desenvolvedor" }
    };
}
