Entrega entregaDePizza = new Entrega(representante: "Marcela");
Colaborador joseDaAlura = new Colaborador(idAcesso: 25);
Colaborador mariaDaAcme = new Colaborador(idAcesso: 14);
Visitante filhoDeMaria = new Visitante(nome: "Pedro", documento: "12938732");

RelatorioDeAcesso acessoMensal = new RelatorioDeAcesso();
acessoMensal.RegistrarEntrada(entregaDePizza);
acessoMensal.RegistrarEntrada(joseDaAlura);
acessoMensal.RegistrarEntrada(mariaDaAcme);
acessoMensal.RegistrarEntrada(filhoDeMaria);

// ao final do mês...
acessoMensal.ExibirRegistroDoMes();

internal class Entrega : IAcessivel
{
    public Entrega(string representante)
    {
        Representante = representante;
    }

    public string Representante { get; }
    public string Informacao => $"Entrega feita por {Representante}";
}

internal class Colaborador : IAcessivel
{
    public Colaborador(int idAcesso)
    {
        IdAcesso = idAcesso;
    }

    public int IdAcesso { get; }
    public string Informacao => $"Entrada de colaborador com id {IdAcesso}";
}

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

internal interface IAcessivel
{
    string Informacao { get; }
}

internal class RelatorioDeAcesso
{
    private List<AcessoAoPredio> acessos = new();
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