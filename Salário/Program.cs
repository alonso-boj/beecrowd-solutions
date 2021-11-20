//https://www.beecrowd.com.br/judge/pt/problems/view/1008
using System;

class URI {

  static void Main(string[] args) {

    int numeroFunc, horasTrabalhadas;
    double valorHora, salario;

    numeroFunc = int.Parse(Console.ReadLine());
    horasTrabalhadas = int.Parse(Console.ReadLine());
    valorHora = double.Parse(Console.ReadLine());

    salario = horasTrabalhadas * valorHora;

    Console.WriteLine("NUMBER = " + numeroFunc);
    Console.WriteLine("SALARY = U$ {0:0.00}", salario);
    Console.ReadLine();


  }

}