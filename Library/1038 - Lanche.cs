// https://www.beecrowd.com.br/judge/pt/problems/view/1038
using System;
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {

    var cardapio = new Dictionary<int, double> { { 1, 4.00 }, {2, 4.50 }, {3, 5.00}, {4, 2.00}, {5, 1.50} };

    string[] pedido = Console.ReadLine().Split();

    int codigo = int.Parse(pedido[0]);
    int quantidade = int.Parse(pedido[1]);

    double total = cardapio[codigo] * quantidade;

    Console.WriteLine("Total: R$ {0:0.00}", total);
    Console.ReadLine();
  }
}