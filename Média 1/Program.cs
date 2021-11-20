//https://www.beecrowd.com.br/judge/pt/problems/view/1005
using System;

class URI {

  static void Main(string[] args) {

    float A = float.Parse(Console.ReadLine());
    float B = float.Parse(Console.ReadLine());

    double nota = ((A * 3.5) + (B * 7.5)) / 11;

    Console.WriteLine("MEDIA = {0:0.00000}", nota);
    Console.ReadLine();
  }

}