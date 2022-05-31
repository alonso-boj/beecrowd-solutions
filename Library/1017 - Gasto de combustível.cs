// https://www.beecrowd.com.br/judge/pt/problems/view/1017
using System;

class URI {

  static void Main(string[] args) {

    int tempo = int.Parse(Console.ReadLine());
    int velocidadeMedia = int.Parse(Console.ReadLine());

    int dist = tempo * velocidadeMedia;

    double gastoTotal = dist / 12.0;

    Console.WriteLine("{0:0.000}", gastoTotal);
    Console.ReadLine();

  }

}