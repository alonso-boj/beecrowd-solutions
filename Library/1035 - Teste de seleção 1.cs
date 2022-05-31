// https://www.beecrowd.com.br/judge/pt/problems/view/1035

using System;
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {

    string[] entrada = Console.ReadLine().Split();

    var listaDeNumeros = new List<int>();

    foreach (var numero in entrada) {
      listaDeNumeros.Add(int.Parse(numero));
    }

    if (listaDeNumeros[1] > listaDeNumeros[2] &&
    listaDeNumeros[3] > listaDeNumeros[0] &&
    listaDeNumeros[2] + listaDeNumeros[3] > listaDeNumeros[0] + listaDeNumeros[1] &&
    listaDeNumeros[2] > 0 && listaDeNumeros[3] > 0) {

      Console.WriteLine("Valores aceitos");
    }
    else {
      Console.WriteLine("Valores nao aceitos");
    }
    Console.ReadLine();
  }
}