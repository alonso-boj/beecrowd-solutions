//https://www.beecrowd.com.br/judge/pt/problems/view/1013
using System;

class URI {

  static void Main(string[] args) {

    int a, b, c, maiorAB, maior;

    string[] lista = Console.ReadLine().Split(' ');

    a = int.Parse(lista[0]);
    b = int.Parse(lista[1]);
    c = int.Parse(lista[2]);

    maiorAB = (a + b + Math.Abs(a - b)) / 2;
    maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

    Console.WriteLine(maior + " eh o maior");
    Console.ReadLine();

  }

}