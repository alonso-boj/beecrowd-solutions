// https://www.beecrowd.com.br/judge/pt/problems/view/1046
using System;

class URI
{
  static void Main(string[] args)
  {
    string[] entrada = Console.ReadLine().Split();

    int inicio = int.Parse(entrada[0]);
    int fim = int.Parse(entrada[1]);
    int resultado;

    if (fim == inicio)
    {
      Console.WriteLine("O JOGO DUROU 24 HORA(S)");
    }

    else if (fim > inicio)
    {
      resultado = fim - inicio;
      Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
    }

    else
    {
      inicio = 24 - inicio;
      resultado = inicio + fim;
      Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
    }
    Console.ReadLine();
  }
}