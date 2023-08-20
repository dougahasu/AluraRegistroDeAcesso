using RegistroDeAcesso.ConsoleApp.Interfaces;

namespace RegistroDeAcesso.Modelos;

internal class Colaborador : IAcessivel
{
    public Colaborador(int idAcesso)
    {
        IdAcesso = idAcesso;
    }

    public int IdAcesso { get; }
    public string Informacao => $"Entrada de colaborador com id {IdAcesso}";
}