// https://www.beecrowd.com.br/judge/pt/problems/view/1044
using System;

class URI
{
  static void Main(string[] args)
  {
    string[] entrada = Console.ReadLine().Split();

    double a = double.Parse(entrada[0]);
    double b = double.Parse(entrada[1]);

    if (a % b == 0 || b % a == 0)
    {
      Console.WriteLine("Sao Multiplos");
    }
    else
    {
      Console.WriteLine("Nao sao Multiplos");
    }

    Console.ReadLine();
  }
}