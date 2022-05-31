// https://www.beecrowd.com.br/judge/pt/problems/view/1019
using System;

class URI {

  static void Main(string[] args) {

    int segundos = int.Parse(Console.ReadLine());

    int horas = segundos / 3600;
    segundos %= 3600;

    int minutos = segundos / 60;
    segundos %= 60;

    
    Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
    Console.ReadLine();
  }

}