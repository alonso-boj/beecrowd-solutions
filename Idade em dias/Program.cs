// https://www.beecrowd.com.br/judge/pt/problems/view/1020
using System;

class URI {

  static void Main(string[] args) {

    int dias = int.Parse(Console.ReadLine());

    int anos = dias / 365;
    dias %= 365;

    int meses = dias / 30;
    dias %= 30;

    Console.WriteLine("{0} ano(s)", anos);
    Console.WriteLine("{0} mes(es)", meses);
    Console.WriteLine("{0} dia(s)", dias);

    Console.ReadLine();
  }

}