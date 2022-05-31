using System;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd
{
  class Program
  {
    static void Main(string[] args)
    {
      var numberOfEntries = uint.Parse(Console.ReadLine());

      var entries = new List<uint>();

      for (int i = 0; i < numberOfEntries; i++)
      {
        var entry = uint.Parse(Console.ReadLine());

        entries.Add(entry);
      }

      var evenList = new List<uint>();

      foreach (var entry in entries.Where(entry => entry % 2 == 0))
      {
        evenList.Add(entry);
      }

      evenList.Sort();
      evenList.ForEach(number => Console.WriteLine(number));

      var unevenList = new List<uint>();

      foreach (var entry in entries.Where(entry => entry % 2 != 0))
      {
        unevenList.Add(entry);
      }

      unevenList.Sort();
      unevenList.Reverse();
      unevenList.ForEach(number => Console.WriteLine(number));

      Console.ReadLine();
    }
  }
}
