using System;

class URI
{
  static void Main(string[] args)
  {
    string[] entrada = Console.ReadLine().Split();

    double a = double.Parse(entrada[0]);
    double b = double.Parse(entrada[1]);
    double c = double.Parse(entrada[2]);

    if (a + b > c && a + c > b && b + c > a)
    {
      double perimetro = a + b + c;
      Console.WriteLine("Perimetro = {0:0.0}", perimetro);
    }
    else
    {
      double area = (a + b) / 2 * c;
      Console.WriteLine("Area = {0:0.0}", area);
    }
    Console.ReadLine();
  }
}