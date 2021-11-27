// https://www.beecrowd.com.br/judge/pt/problems/view/1244

using System;
using System.Linq;
using System.Text;

namespace Ordenação_por_tamanho {
  internal class Program {
    static void Main(string[] args) {

      string entrada;

      StringBuilder saida = new StringBuilder();

      int repeticoes = int.Parse(Console.ReadLine());

      for (int i = 0; i < repeticoes; i++) {

        entrada = Console.ReadLine();

        string[] arrayDePalavras = entrada.Trim().Split();

        var ordenacao = from palavra in arrayDePalavras orderby palavra.Length descending select palavra;

        StringBuilder processamento = new StringBuilder();
        processamento.Clear();

        foreach (string palavra in ordenacao) {

          processamento.Append(palavra + " ");
        }

        processamento.Remove(processamento.Length - 1, 1);

        saida.Append(processamento + "\n");

      }

      Console.Write(saida);
      Console.ReadLine();
    }
  }
}
