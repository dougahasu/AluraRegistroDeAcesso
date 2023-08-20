using RegistroDeAcesso.ConsoleApp.Interfaces;

namespace RegistroDeAcesso.ConsoleApp.Controllers;

internal class RelatorioDeAcesso
{
    private readonly List<AcessoAoPredio> acessos = new();
    public void RegistrarEntrada(IAcessivel quem)
    {
        acessos.Add(new AcessoAoPredio(DateTime.Now, quem.Informacao));
    }

    public void ExibirRegistroDoMes()
    {
        Console.WriteLine("Acessos registrados no mês:");
        foreach (var acesso in acessos)
        {
            Console.WriteLine($"- {acesso.Resumo} em {acesso.Quando}");
        }
    }
}