// https://www.beecrowd.com.br/judge/pt/problems/view/1036
using System;

class URI {

  static void Main(string[] args) {

    double a, b, c;

    string[] entrada = Console.ReadLine().Split();

    a = double.Parse(entrada[0]);
    b = double.Parse(entrada[1]);
    c = double.Parse(entrada[2]);

    double delta = Math.Pow(b, 2) - (4 * a * c);
    if (2 * a == 0 || delta < 0) {
      Console.WriteLine("Impossivel calcular");
    }

    else {
      double x1 = (-1 * b + Math.Sqrt(delta)) / (2 * a);
      double x2 = (-1 * b - Math.Sqrt(delta)) / (2 * a);

      Console.WriteLine("R1 = {0:0.00000}", x1);
      Console.WriteLine("R2 = {0:0.00000}", x2);
    }

    Console.ReadLine();

  }

}