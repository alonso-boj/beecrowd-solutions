// https://www.beecrowd.com.br/judge/pt/problems/view/1234
using System;
using System.Collections.Generic;

  class URI {
  static void Main(string[] args) {

    string entrada;

    List<string> resultado = new List<string> { };

    int contador = 0;

    while (!string.IsNullOrWhiteSpace(entrada = Console.ReadLine())) {

        char[] caracteresArray = entrada.ToCharArray();

        bool flag = true;
        string processamento = "";

        for (int i = 0; i < caracteresArray.Length; i++) {

          if (caracteresArray[i] != ' ') {
            if (flag) {

              processamento += char.ToUpper(caracteresArray[i]);
            }

            else {
              processamento += char.ToLower(caracteresArray[i]);
            }

            flag = !flag;
          }

          else {
            processamento += " ";
          }
        }

        resultado.Insert(contador, processamento);
        contador++;

      }

      for (int i = 0; i < contador; i++) {

        Console.Write(resultado[i]);
        Console.WriteLine();

      }
      Console.ReadLine();

    }

  }