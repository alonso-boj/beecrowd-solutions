// https://www.beecrowd.com.br/judge/pt/problems/view/1042
using System;
using System.Collections.Generic;

class URI
{
  static void Main(string[] args)
  {

    string[] entrada = Console.ReadLine().Split();

    int primeiroNumero = int.Parse(entrada[0]);
    int segundoNumero = int.Parse(entrada[1]);
    int terceiroNumero = int.Parse(entrada[2]);

    var listaNumeros = new List<int>();

    listaNumeros.Add(primeiroNumero);
    listaNumeros.Add(segundoNumero);
    listaNumeros.Add(terceiroNumero);

    listaNumeros.Sort();

    foreach (var numero in listaNumeros)
    {
      Console.WriteLine(numero);
    }

    Console.WriteLine();

    Console.WriteLine(primeiroNumero);
    Console.WriteLine(segundoNumero);
    Console.WriteLine(terceiroNumero);

    Console.ReadLine();

  }
}