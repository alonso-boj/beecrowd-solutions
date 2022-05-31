// https://www.beecrowd.com.br/judge/pt/problems/view/1051
using System;

class URI
{
  static void Main(string[] args)
  {

    decimal entrada = decimal.Parse(Console.ReadLine());
    decimal total;

    if (entrada <= 2000.00m)
    {
      Console.WriteLine("Isento");
      Console.ReadKey();
      return;
    }

    if (entrada > 2000.00m && entrada <= 3000.00m)
    {
      total = (entrada - 2000.00m) * 0.08m;
      Console.WriteLine("R$ {0:0.00}", total);
      Console.ReadKey();
      return;
    }

    if (entrada > 3000.00m && entrada <= 4500.00m)
    {
      total = 80 + (entrada - 3000.00m) * 0.18m;
      Console.WriteLine("R$ {0:0.00}", total);
      Console.ReadKey();
      return;
    }

    if (entrada > 4500.00m)
    {
      total = 80 + 270 + (entrada - 4500.00m) * 0.28m;
      Console.WriteLine("R$ {0:0.00}", total);
      Console.ReadKey();
      return;
    }
  }
}