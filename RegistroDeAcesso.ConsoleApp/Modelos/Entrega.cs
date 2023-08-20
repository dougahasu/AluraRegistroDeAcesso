using RegistroDeAcesso.ConsoleApp.Interfaces;

namespace RegistroDeAcesso.Modelos;

internal class Entrega : IAcessivel
{
    public Entrega(string representante)
    {
        Representante = representante;
    }
    public string Representante { get; }
    public string Informacao => $"Entrega feita por {Representante}";
}