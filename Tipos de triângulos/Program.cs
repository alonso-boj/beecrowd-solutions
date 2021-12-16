// https://www.beecrowd.com.br/judge/pt/problems/view/1045
using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
  static void Main(string[] args)
  {
    string[] entrada = Console.ReadLine().Split();

    double primeiroNumero = double.Parse(entrada[0]);
    double segundoNumero = double.Parse(entrada[1]);
    double terceiroNumero = double.Parse(entrada[2]);

    var listaDeNumeros = new List<double>() {
        primeiroNumero, segundoNumero, terceiroNumero
    };

    var listaOrdenada = listaDeNumeros.OrderByDescending(x => x).ToList();

    double a = listaOrdenada[0];
    double b = listaOrdenada[1];
    double c = listaOrdenada[2];

    if (a >= b + c)
    {
      Console.WriteLine("NAO FORMA TRIANGULO");
    }

    else
    {
      if (a * a == (b * b + c * c))
      {
        Console.WriteLine("TRIANGULO RETANGULO");
      }

      if (a * a > (b * b + c * c))
      {
        Console.WriteLine("TRIANGULO OBTUSANGULO");
      }

      if (a * a < (b * b + c * c))
      {
        Console.WriteLine("TRIANGULO ACUTANGULO");
      }

      if (a == b && b == c)
      {
        Console.WriteLine("TRIANGULO EQUILATERO");
      }

      else if (a == b || b == c)
      {
        Console.WriteLine("TRIANGULO ISOSCELES");
      }
    }

    Console.ReadLine();
  }
}