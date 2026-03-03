// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");
Cliente cliente;
cliente = new Cliente();
cliente.Nome = "Seu nome";
cliente.Cpf = "12345678910";

Console.WriteLine($"Nome do cliente:{cliente.Nome}");
Console.WriteLine($"Nome do cliente:{cliente.Cpf}");


