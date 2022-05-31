// https://www.beecrowd.com.br/judge/pt/problems/view/1234
using System;
using System.Text;

class URI
{
  static void Main(string[] args)
  {
    string entry;

    var result = new StringBuilder();

    while (!string.IsNullOrWhiteSpace(entry = Console.ReadLine()))
    {
      bool setToUpper = false;

      for (int i = 0; i < entry.Length; i++)
      {
        if (entry[i] == ' ')
        {
          result.Append(' ');
          continue;
        }

        if (setToUpper == false)
        {
          result.Append(char.ToUpper(entry[i]));
          setToUpper = true;
          continue;
        }

        result.Append(char.ToLower(entry[i]));
        setToUpper = false;
      }

      result.Append(Environment.NewLine);
    }

    Console.Write(result.ToString());
  }
}