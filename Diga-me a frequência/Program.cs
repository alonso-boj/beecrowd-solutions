//https://www.beecrowd.com.br/judge/pt/problems/view/1251
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _1251 {
  class Program {
    static void Main(string[] args) {

      string entrada = null;
      var entradas = new List<string>();

      while (!string.IsNullOrEmpty(entrada = Console.ReadLine())) {

        if (entrada.Length >= 1001)
          continue;

        entradas.Add(entrada);
      }

      bool line = false;

      foreach (var input in entradas) {

        if (line)

        Console.Write(Environment.NewLine);
        var formatted = input.Trim().Replace("\n", "").Replace("\r", "");
        StringBuilder saida = new StringBuilder();
        List<char> listaDeCaracteres = new List<char>();
        listaDeCaracteres.AddRange(formatted);
        Dictionary<char, int> dicionarioDePalavras = new Dictionary<char, int>();

        foreach (char caractere in listaDeCaracteres) {

          var charInt = (int)caractere;

          if (charInt <= 31 || charInt >= 128) continue;
          if (dicionarioDePalavras.ContainsKey(caractere)) {
            dicionarioDePalavras[caractere]++;
          }
          else {
            dicionarioDePalavras.Add(caractere, 1);
          }
        }
        foreach (KeyValuePair<char, int> caractere in dicionarioDePalavras.OrderBy(d => d.Value).ThenByDescending(d => d.Key)) {
          saida.AppendLine($"{(int)caractere.Key} {caractere.Value}");
        }
        Console.Write(saida);

        line = true;

        Console.ReadLine();
      }
    }
  }
}