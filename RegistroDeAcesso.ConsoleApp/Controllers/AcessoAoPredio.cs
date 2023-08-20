namespace RegistroDeAcesso.ConsoleApp.Controllers;

internal class AcessoAoPredio
{
    public AcessoAoPredio(DateTime quando, string resumo)
    {
        Quando = quando;
        Resumo = resumo;
    }

    public DateTime Quando { get; }
    public string Resumo { get; }
}