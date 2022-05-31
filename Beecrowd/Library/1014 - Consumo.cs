//https://www.beecrowd.com.br/judge/pt/problems/view/1014
using System;

class URI {

  static void Main(string[] args) {

    int distancia = int.Parse(Console.ReadLine());
    double combustivel = double.Parse(Console.ReadLine());

    double consumo = distancia / combustivel;

    Console.WriteLine("{0:0.000} km/l", consumo);
    Console.ReadLine();

  }

}