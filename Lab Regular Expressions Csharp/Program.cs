using System;
using System.Text.RegularExpressions;

namespace Lab_Regular_Expressions_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            string names = Console.ReadLine();

            
            MatchCollection matchCollection = Regex.Matches(names, pattern);
            foreach (Match match in matchCollection)
            {
                Console.Write(match.Value + " ");

            }
            Console.WriteLine();

        }
    }
}
