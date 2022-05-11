using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beecrowd
{
  class Program
  {
    static void Main(string[] args)
    {
      var result = new StringBuilder();

      var caseTestsNumber = int.Parse(Console.ReadLine());

      var entry = new List<string>();

      for (int i = 0; i < caseTestsNumber; i++)
      {
        var entryList = Console.ReadLine().Split(' ');

        entry.Clear();

        entry.AddRange(entryList);

        if (entry.Count > 50) continue;

        foreach (var word in entry.OrderByDescending(l => l.Length))
        {
          if (word.Count() > 50) continue;
          result.Append(word + ' ');
        }

        result.Remove(result.Length - 1, 1);

        result.AppendLine();
      }

      Console.Write(result);

      Console.ReadLine();
    }
  }
}
