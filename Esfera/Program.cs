//https://www.beecrowd.com.br/judge/pt/problems/view/1011
using System;

class URI {

  static void Main(string[] args) {

    double pi, raio, volume;
    pi = 3.14159;

    raio = double.Parse(Console.ReadLine());

    volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

    Console.WriteLine("VOLUME = {0:0.000}", volume);
    Console.ReadLine();

  }

}