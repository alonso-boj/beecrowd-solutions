// https://www.beecrowd.com.br/judge/pt/problems/view/1037
using System;

namespace Intervalo {
  internal class Program {
    static void Main(string[] args) {

      decimal entrada = decimal.Parse(Console.ReadLine());

      if (entrada >= 0 && entrada <= 25) {
        Console.WriteLine("Intervalo [0,25]");
      }

      else if (entrada > 25 && entrada <= 50) {
        Console.WriteLine("Intervalo (25,50]");
      }

      else if (entrada > 50 && entrada <= 75) {
        Console.WriteLine("Intervalo (50,75]");
      }

      else if (entrada > 75 && entrada <= 100) {
        Console.WriteLine("Intervalo (75,100]");
      }

      else {
        Console.WriteLine("Fora de intervalo");
      }

      Console.ReadLine();

    }
  }
}
