// https://www.beecrowd.com.br/judge/pt/problems/view/1015
using System;

class URI {

  static void Main(string[] args) {

    double distDoisPontos;

    // Entradas em texto e split.
    string[] entrada1 = Console.ReadLine().Split(' ');
    string[] entrada2 = Console.ReadLine().Split(' ');

    // Inicialização dos vetores ponto1 e ponto 2 e respectivas
    // atribuições dos valores obtidos pelos métodos split.
    double[] ponto1 = new double[2];
    ponto1[0] = double.Parse(entrada1[0]);
    ponto1[1] = double.Parse(entrada1[1]);

    double[] ponto2 = new double[2];
    ponto2[0] = double.Parse(entrada2[0]);
    ponto2[1] = double.Parse(entrada2[1]);

    // Processamento.
    distDoisPontos = Math.Sqrt(
      Math.Pow(ponto2[0] - ponto1[0], 2) + Math.Pow(ponto2[1] - ponto1[1], 2)
      );

    Console.WriteLine("{0:0.0000}", distDoisPontos);
    Console.ReadLine();
  }

}