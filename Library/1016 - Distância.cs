// https://www.beecrowd.com.br/judge/pt/problems/view/1016
using System;

class URI {

  static void Main(string[] args) {

    int distancia, tempo;
    distancia = int.Parse(Console.ReadLine());

    tempo = distancia * 2;

    Console.WriteLine(tempo + " minutos");
    Console.ReadLine();
  }
}