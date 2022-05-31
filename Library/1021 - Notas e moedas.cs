// https://www.beecrowd.com.br/judge/pt/problems/view/1021
using System;

class URI {

  static void Main(string[] args) {

      decimal numero = decimal.Parse(Console.ReadLine());

      decimal[] contadorCedulas = { 0, 0, 0, 0, 0, 0 };
      decimal[] contadorMoedas = { 0, 0, 0, 0, 0, 0 };

      // Contagem de notas
      while (numero >= 100) {
        numero -= 100;
        contadorCedulas[0]++;
      }

      while (numero >= 50) {
        numero -= 50;
        contadorCedulas[1]++;
      }

      while (numero >= 20) {
        numero -= 20;
        contadorCedulas[2]++;
      }

      while (numero >= 10) {
        numero -= 10;
        contadorCedulas[3]++;
      }

      while (numero >= 5) {
        numero -= 5;
        contadorCedulas[4]++;
      }

      while (numero >= 2) {
        numero -= 2;
        contadorCedulas[5]++;
      }

      // Contagem de moedas
      while (numero >= 1) {
        numero -= 1;
        contadorMoedas[0]++;
      }

      while (numero >= 0.50m) {
        numero -= 0.50m;
        contadorMoedas[1]++;
      }

      while (numero >= 0.25m) {
        numero -= 0.25m;
        contadorMoedas[2]++;
      }

      while (numero >= 0.10m) {
        numero -= 0.10m;
        contadorMoedas[3]++;
      }

      while (numero >= 0.05m) {
        numero -= 0.05m;
        contadorMoedas[4]++;
      }

      while (numero >= 0.01m) {
        numero -= 0.01m;
        contadorMoedas[5]++;
      }

      Console.WriteLine("NOTAS:");
      Console.WriteLine(contadorCedulas[0] + " nota(s) de R$ 100.00");
      Console.WriteLine(contadorCedulas[1] + " nota(s) de R$ 50.00");
      Console.WriteLine(contadorCedulas[2] + " nota(s) de R$ 20.00");
      Console.WriteLine(contadorCedulas[3] + " nota(s) de R$ 10.00");
      Console.WriteLine(contadorCedulas[4] + " nota(s) de R$ 5.00");
      Console.WriteLine(contadorCedulas[5] + " nota(s) de R$ 2.00");

      Console.WriteLine("MOEDAS:");
      Console.WriteLine(contadorMoedas[0] + " moeda(s) de R$ 1.00");
      Console.WriteLine(contadorMoedas[1] + " moeda(s) de R$ 0.50");
      Console.WriteLine(contadorMoedas[2] + " moeda(s) de R$ 0.25");
      Console.WriteLine(contadorMoedas[3] + " moeda(s) de R$ 0.10");
      Console.WriteLine(contadorMoedas[4] + " moeda(s) de R$ 0.05");
      Console.WriteLine(contadorMoedas[5] + " moeda(s) de R$ 0.01");

      Console.ReadLine();

    }
  }
