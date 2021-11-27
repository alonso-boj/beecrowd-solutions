// https://www.beecrowd.com.br/judge/pt/problems/view/1259
using System;
using System.Collections.Generic;

namespace Pares_e_ímpares {
  internal class Program {

    static void Main(string[] args) {

      long quantidadeDeEntradas = long.Parse(Console.ReadLine());

      List<int> listaDePares = new List<int>();
      List<int> listaDeImpares = new List<int>();

      for (int i = 0; i < quantidadeDeEntradas; i++) {

        int entrada = int.Parse(Console.ReadLine());

        if (entrada % 2 == 0) {
          listaDePares.Add(entrada);
        }
        else {
          listaDeImpares.Add(entrada);
        }
      }

      listaDePares.Sort();
      listaDeImpares.Sort();
      listaDeImpares.Reverse();

      for (int i = 0; i < listaDePares.Count; i++) {

        Console.WriteLine(listaDePares[i]);
      }

      for (int i = 0; i < listaDeImpares.Count; i++) {

        Console.WriteLine(listaDeImpares[i]);
      }

      Console.ReadLine();
    }
  }
}
