using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diga_me_a_frequência {
  internal class Program {
    static void Main(string[] args) {

      string entrada;

      StringBuilder saida = new StringBuilder();

      while (!string.IsNullOrEmpty(entrada = Console.ReadLine())) {

        List<char> listaDeCaracteres = new List<char>();

        listaDeCaracteres.AddRange(entrada);

        Dictionary<char, int> dicionarioDePalavras = new Dictionary<char, int>();

        foreach (char caractere in listaDeCaracteres) {

          if (dicionarioDePalavras.ContainsKey(caractere)) {
            dicionarioDePalavras[caractere]++;
          }
          else {
            dicionarioDePalavras.Add(caractere, 1);
          }
        }

        foreach (KeyValuePair<char, int> caractere in dicionarioDePalavras.OrderBy(d => d.Value)) {

          saida.AppendLine($"{(int)caractere.Key} {caractere.Value}");
        }
        saida.AppendLine();
      }
      Console.Write(saida);
      Console.ReadLine();
    }
  }

}
