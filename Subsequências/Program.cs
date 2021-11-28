// https://www.beecrowd.com.br/judge/pt/problems/view/1507

using System;
using System.Text;

namespace Subsequências {
  internal class Program {
    public static bool verificacao(string principal, string substring) {

      int caracteresCorrespondentes = 0;
      int indice = 0;

      foreach (char caractere in principal) {
        if (caractere == substring[indice]) {
          caracteresCorrespondentes++;
          indice++;

          if (caracteresCorrespondentes == substring.Length) {
            return true;
          }
        }
      }
      return false;
    }
    static void Main(string[] args) {

      StringBuilder saida = new StringBuilder();

      int quantidadeDeTestes = int.Parse(Console.ReadLine());

      for (int i = 0; i < quantidadeDeTestes; i++) {

        string stringPrincipal = Console.ReadLine();
        int quantidadeDeQueries = int.Parse(Console.ReadLine());

        for (int j = 0; j < quantidadeDeQueries; j++) {

          string substring = Console.ReadLine();

          if (verificacao(stringPrincipal, substring)) {
            saida.AppendLine("Yes");
          }
          else {
            saida.AppendLine("No");
          }
        }
      }
      Console.Write(saida);
      Console.ReadLine();
    }
  }
}