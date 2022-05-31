using System;
using System.Text;

namespace Beecrowd
{
  class Program
  {
    static void Main(string[] args)
    {
      var result = new StringBuilder();

      var caseTestsNumber = uint.Parse(Console.ReadLine());

      for (int i = 0; i < caseTestsNumber; i++)
      {
        var entry = Console.ReadLine();

        if (entry.Length < 0 || entry.Length > 100000) continue;

        var queryNumber = uint.Parse(Console.ReadLine());

        if (queryNumber < 0 || queryNumber > 1000) continue;

        for (int j = 0; j < queryNumber; j++)
        {
          var query = Console.ReadLine();

          if (Verify(entry, query)) result.AppendLine("Yes");

          else result.AppendLine("No");
        }
      }

      Console.Write(result);

      Console.ReadLine();
    }

    public static bool Verify(string entry, string substring)
    {
      int matchingCharacters = 0;
      int index = 0;

      foreach (var character in entry)
      {
        if (character == substring[index])
        {
          matchingCharacters++;
          index++;
        }

        if (matchingCharacters == substring.Length) return true;
      }

      return false;
    }
  }
}
