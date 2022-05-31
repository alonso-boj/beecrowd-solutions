// https://www.beecrowd.com.br/judge/pt/problems/view/1040
using System;

namespace Media_3 {

  public class Aluno {
    public double NotaUm { get; set; }
    public double NotaDois { get; set; }
    public double NotaTres { get; set; }
    public double NotaQuatro { get; set; }
    public double Media { get; set; }

    public double NotaExame { get; set; }

    public static double CalcularMediaPonderada(Aluno aluno) {

      return aluno.Media = ((aluno.NotaUm * 2) + (aluno.NotaDois * 3) +
      (aluno.NotaTres * 4) + (aluno.NotaQuatro * 1)) / 10;

    }
  }

  internal class Program {

    public static void Main(string[] args) {

      string[] entrada = Console.ReadLine().Split();

      var aluno = new Aluno
      {
        NotaUm = double.Parse(entrada[0]),
        NotaDois = double.Parse(entrada[1]),
        NotaTres = double.Parse(entrada[2]),
        NotaQuatro = double.Parse(entrada[3])
      };

      Aluno.CalcularMediaPonderada(aluno);

      if (aluno.Media < 5.0) {
        Console.WriteLine("Media: {0:0.0}", Math.Truncate(aluno.Media*10)/10);
        Console.WriteLine("Aluno reprovado.");

      }

      if (aluno.Media >= 7.0) {
        Console.WriteLine("Media: {0:0.0}", Math.Truncate(aluno.Media * 10) / 10);
        Console.WriteLine("Aluno aprovado.");
      }

      if (aluno.Media >= 5.0 && aluno.Media < 7.0) {
        Console.WriteLine("Media: {0:0.0}", Math.Truncate(aluno.Media * 10) / 10);
        Console.WriteLine("Aluno em exame.");

        aluno.NotaExame = double.Parse(Console.ReadLine());
        Console.WriteLine("Nota do exame: {0:0.0}", aluno.NotaExame);

        aluno.Media = (aluno.Media + aluno.NotaExame) / 2;

        if (aluno.Media >= 5.0) {
          Console.WriteLine("Aluno aprovado.");
        }
        else {
          Console.WriteLine("Aluno reprovado.");
        }
        Console.WriteLine("Media final: {0:0.0}", Math.Truncate(aluno.Media * 10) / 10);
      }
      Console.ReadLine();
    }
  }
}
