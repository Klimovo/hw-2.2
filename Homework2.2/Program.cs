using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        Console.WriteLine("Введіть рядок для фільтрації:");
        string input = Console.ReadLine();

        string[] forbiddenWords = { "bad", "word", "example" };

        string pattern = @"\b(" + string.Join("|", forbiddenWords.Select(Regex.Escape)) + @")\b";

        string filteredString = Regex.Replace(input, pattern, match => new string('#', match.Length), RegexOptions.IgnoreCase);

        Console.WriteLine("Результат фільтрації:");
        Console.WriteLine(filteredString);

        //commit
    }
}
