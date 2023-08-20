using RegistroDeAcesso.ConsoleApp.Interfaces;

namespace RegistroDeAcesso.Modelos;

internal class Visitante : IAcessivel
{
    public Visitante(string nome, string documento)
    {
        Nome = nome;
        Documento = documento;
    }

    public string Nome { get; }
    public string Documento { get; }
    public string Informacao => $"Visita de {Nome} doc nº {Documento}";
}