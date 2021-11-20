//https://www.beecrowd.com.br/judge/pt/problems/view/1012
using System;

class URI {

  static void Main(string[] args) {

    double A, B, C, pi = 3.14159, triangulo, circulo, trapezio, quadrado, retangulo;
    string[] entrada = Console.ReadLine().Split(' ');

    A = double.Parse(entrada[0]);
    B = double.Parse(entrada[1]);
    C = double.Parse(entrada[2]);

    triangulo = (A * C) / 2;
    Console.WriteLine("TRIANGULO: {0:0.000}", triangulo);

    circulo = pi * Math.Pow(C, 2);
    Console.WriteLine("CIRCULO: {0:0.000}", circulo);

    trapezio = ((A + B) / 2) * C;
    Console.WriteLine("TRAPEZIO: {0:0.000}", trapezio);

    quadrado = Math.Pow(B, 2);
    Console.WriteLine("QUADRADO: {0:0.000}", quadrado);

    retangulo = (A * B);
    Console.WriteLine("RETANGULO: {0:0.000}", retangulo);

    Console.ReadLine();

  }

}