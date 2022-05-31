// https://www.beecrowd.com.br/judge/pt/problems/view/1049
using System;

class URI
{
  static void Main(string[] args)
  {
    string primeiraEntrada = Console.ReadLine();
    string segundaEntrada = Console.ReadLine();
    string terceiraEntrada = Console.ReadLine();

    if (primeiraEntrada == "vertebrado" &&
        segundaEntrada == "ave")
    {
      if (terceiraEntrada == "carnivoro")
      {
        Console.WriteLine("aguia");
      }
      else
      {
        Console.WriteLine("pomba");
      }
    }

    if (primeiraEntrada == "vertebrado" &&
        segundaEntrada == "mamifero")
    {
      if (terceiraEntrada == "onivoro")
      {
        Console.WriteLine("homem");
      }
      else
      {
        Console.WriteLine("vaca");
      }
    }

    if (primeiraEntrada == "invertebrado" &&
        segundaEntrada == "inseto")
    {
      if (terceiraEntrada == "hematofago")
      {
        Console.WriteLine("pulga");
      }
      else
      {
        Console.WriteLine("lagarta");
      }
    }

    if (primeiraEntrada == "invertebrado" &&
        segundaEntrada == "anelideo")
    {
      if (terceiraEntrada == "hematofago")
      {
        Console.WriteLine("sanguessuga");
      }
      else
      {
        Console.WriteLine("minhoca");
      }
    }
    Console.ReadLine();
  }
}