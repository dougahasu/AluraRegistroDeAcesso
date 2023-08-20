using RegistroDeAcesso.ConsoleApp.Controllers;
using RegistroDeAcesso.Modelos;

Entrega entregaDePizza = new(representante: "Marcela");
Colaborador joseDaAlura = new(idAcesso: 25);
Colaborador mariaDaAcme = new(idAcesso: 14);
Visitante filhoDeMaria = new(nome: "Pedro", documento: "12938732");

RelatorioDeAcesso acessoMensal = new();
acessoMensal.RegistrarEntrada(entregaDePizza);
acessoMensal.RegistrarEntrada(joseDaAlura);
acessoMensal.RegistrarEntrada(mariaDaAcme);
acessoMensal.RegistrarEntrada(filhoDeMaria);

acessoMensal.ExibirRegistroDoMes();