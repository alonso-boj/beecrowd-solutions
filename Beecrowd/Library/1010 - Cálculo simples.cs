//https://www.beecrowd.com.br/judge/pt/problems/view/1010
using System;

class URI {

  static void Main(string[] args) {

    int cod, qtd;
    double valor, total;

    string[] produto1 = Console.ReadLine().Split(' ');
    string[] produto2 = Console.ReadLine().Split(' ');
    
    cod = int.Parse(produto1[0]);
    qtd = int.Parse(produto1[1]);
    valor = double.Parse(produto1[2]);

    total = valor * qtd;

    cod = int.Parse(produto2[0]);
    qtd = int.Parse(produto2[1]);
    valor = double.Parse(produto2[2]);

    total += valor * qtd;

    Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}", total);
    Console.ReadLine();


  }
}