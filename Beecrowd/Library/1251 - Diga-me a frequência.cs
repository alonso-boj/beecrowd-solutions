using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string entry;

      var result = new StringBuilder();

      while (!string.IsNullOrEmpty(entry = Console.ReadLine()))
      {
        if (entry.Length > 1000) continue;

        var dictionary = new Dictionary<char, int>();

        for (int i = 0; i < entry.Length; i++)
        {
          if (entry[i] <= 31 || entry[i] >= 128) continue;

          if (dictionary.ContainsKey(entry[i]))
          {
            dictionary[entry[i]]++;
            continue;
          }

          dictionary.Add(entry[i], 1);
        }

        foreach (var line in dictionary.OrderBy(v => v.Value).ThenByDescending(v => v.Key))
        {
          result.AppendLine($"{(int)line.Key} {line.Value}");
        }

        result.AppendLine();
      }

      result.Remove(result.Length - 1, 1);

      Console.Write(result);

      Console.ReadLine();
    }
  }
}
