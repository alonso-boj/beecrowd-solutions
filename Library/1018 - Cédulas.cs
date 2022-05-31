// https://www.beecrowd.com.br/judge/pt/problems/view/1018
using System;

class URI {

  static void Main(string[] args) {

    long numero = int.Parse(Console.ReadLine());
    Console.WriteLine(numero);
    int[] listaCedulas = {0, 0, 0, 0, 0, 0, 0};

    while (numero >= 100) {
      numero -= 100;
      listaCedulas[0]++;
    }

    while (numero >= 50) {
      numero -= 50;
      listaCedulas[1]++;
    }

    while (numero >= 20) {
      numero -= 20;
      listaCedulas[2]++;
    }

    while (numero >= 10) {
      numero -= 10;
      listaCedulas[3]++;
    }

    while (numero >= 5) {
      numero -= 5;
      listaCedulas[4]++;
    }

    while (numero >= 2) {
      numero -= 2;
      listaCedulas[5]++;
    }

    while (numero >= 1) {
      numero -= 1;
      listaCedulas[6]++;
    }

    Console.WriteLine(listaCedulas[0] + " nota(s) de R$ 100,00");
    Console.WriteLine(listaCedulas[1] + " nota(s) de R$ 50,00");
    Console.WriteLine(listaCedulas[2] + " nota(s) de R$ 20,00");
    Console.WriteLine(listaCedulas[3] + " nota(s) de R$ 10,00");
    Console.WriteLine(listaCedulas[4] + " nota(s) de R$ 5,00");
    Console.WriteLine(listaCedulas[5] + " nota(s) de R$ 2,00");
    Console.WriteLine(listaCedulas[6] + " nota(s) de R$ 1,00");

    Console.ReadLine();

  }

}