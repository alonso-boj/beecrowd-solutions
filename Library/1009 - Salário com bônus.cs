//https://www.beecrowd.com.br/judge/pt/problems/view/1009
using System;

class URI {

  static void Main(string[] args) {

    string nomeVendedor;
    double salario, montante;

    nomeVendedor = Console.ReadLine();
    salario = double.Parse(Console.ReadLine());
    montante = double.Parse(Console.ReadLine());

    salario += (montante * 0.15);

    Console.WriteLine("TOTAL = {0:0.00}", salario);
    Console.ReadLine();

  }

}