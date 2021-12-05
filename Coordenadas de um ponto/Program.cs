// https://www.beecrowd.com.br/judge/pt/problems/view/1041
using System;

namespace Coordenadas_de_um_ponto {
  internal class Program {

    public class Ponto {

      public Ponto(double coordX, double coordY) {

        X = coordX;
        Y = coordY;

      }

      public double X { get; set; }
      public double Y { get; set; }

      public static void VerificarQuadrante(Ponto ponto) {

        if (ponto.X > 0 && ponto.Y > 0) {
          Console.WriteLine("Q1");
        }

        else if (ponto.X < 0 && ponto.Y > 0) {
          Console.WriteLine("Q2");
        }

        else if (ponto.X < 0 && ponto.Y < 0) {
          Console.WriteLine("Q3");
        }

        else if (ponto.X > 0 && ponto.Y < 0) {
          Console.WriteLine("Q4");
        }

        else if (ponto.X == 0 && ponto.Y == 0) {
          Console.WriteLine("Origem");
        }

        else if (ponto.X == 0 && ponto.Y != 0) {
          Console.WriteLine("Eixo Y");
        }

        else if (ponto.X != 0 && ponto.Y == 0) {
          Console.WriteLine("Eixo X");
        }
      }

    }

    static void Main(string[] args) {

      string[] entrada = Console.ReadLine().Split();

      var ponto = new Ponto(double.Parse(entrada[0]), double.Parse(entrada[1]));

      Ponto.VerificarQuadrante(ponto);

      Console.ReadLine();
    }
  }
}
