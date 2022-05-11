using System;

class URI
{
  static void Main(string[] args)
  {

    decimal entrada = decimal.Parse(Console.ReadLine());
    decimal total = 0;

    if (entrada <= 2000.00m)
    {
      Console.WriteLine("Isento");
    }



    Console.WriteLine("R$ {0:0.00}", total);
    Console.ReadLine();
  }
}