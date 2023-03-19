using System;
using System.Text.RegularExpressions;
namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(?<separator>/|-|\.)(?<month>[A-Z][a-z]{2})\<separator>(?<year>\d{4})\b";
            string dates = Console.ReadLine();
            MatchCollection matchCollection = Regex.Matches(dates, pattern);
            foreach (Match match in matchCollection)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            }

        }
    }
}
