// https://www.beecrowd.com.br/judge/pt/problems/view/1047
using System;

class URI
{
  static void Main(string[] args)
  {
    string[] entrada = Console.ReadLine().Split();

    int inicioHoras = int.Parse(entrada[0]);
    int inicioMinutos = int.Parse(entrada[1]);
    int fimHoras = int.Parse(entrada[2]);
    int fimMinutos = int.Parse(entrada[3]);

    int inicio = (inicioHoras * 60) + inicioMinutos;
    int fim = (fimHoras * 60) + fimMinutos;

    int duracaoEmMinutos;

    // Se a duração inicial em minutos for igual à final, passou-se um dia:
    if (inicio == fim)
    {
      Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
    }

    // Se a duração final em minutos for maior...
    else if (fim > inicio)
    {
      duracaoEmMinutos = fim - inicio;
      int horas = duracaoEmMinutos / 60;
      int minutos = duracaoEmMinutos % 60;

      Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
    }

    // Caso contrário...
    else
    {
      duracaoEmMinutos = (24 * 60 - inicio) + fim;
      int horas = duracaoEmMinutos / 60;
      int minutos = duracaoEmMinutos % 60;

      Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
    }
    Console.ReadLine();
  }
}