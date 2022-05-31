//https://www.beecrowd.com.br/judge/pt/problems/view/1006
using System;

class URI {

  static void Main(string[] args) {

    double A, B, C, nota;

    A = double.Parse(Console.ReadLine());
    B = double.Parse(Console.ReadLine());
    C = double.Parse(Console.ReadLine());

    nota = ((A * 2) + (B * 3) + (C * 5)) / 10;

    Console.WriteLine("MEDIA = {0:0.0}", nota);
    Console.ReadLine();

  }

}