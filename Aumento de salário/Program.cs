// https://www.beecrowd.com.br/judge/pt/problems/view/1048
using System;

class URI
{
  static void Main(string[] args)
  {
    decimal salario = decimal.Parse(Console.ReadLine());

    if (salario > 0m && salario <= 400.00m)
    {
      CalcularSalario(salario, 0.15m);
    }

    if (salario >= 400.01m && salario <= 800.00m)
    {
      CalcularSalario(salario, 0.12m);
    }

    if (salario >= 800.01m && salario <= 1200.00m)
    {
      CalcularSalario(salario, 0.10m);
    }

    if (salario >= 1200.01m && salario <= 2000.00m)
    {
      CalcularSalario(salario, 0.07m);
    }

    if (salario >= 2000.01m)
    {
      CalcularSalario(salario, 0.04m);
    }

    Console.ReadLine();
  }

  private static void CalcularSalario(decimal salario, decimal porcentagem)
  {
    decimal reajuste = salario * porcentagem;
    salario += reajuste;

    decimal percentual = porcentagem * 100m;

    Console.WriteLine("Novo salario: {0:0.00}", salario);
    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
    Console.WriteLine("Em percentual: {0:0} %", percentual);
  }
}