using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @" ?\+359( |-)\d{1}\1\d{3}\1\d{4}\b";
            string pattern = @"( |\+359)( |-)2\2\d{3}\2\d{4}\b";


            string phoneNumbers = Console.ReadLine();
            MatchCollection matchCollection = Regex.Matches(phoneNumbers, pattern);

            var matchedNumbers = matchCollection.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedNumbers));
        }
    }
}
