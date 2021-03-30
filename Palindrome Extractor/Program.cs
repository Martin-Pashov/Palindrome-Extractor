using System;
using System.Text.RegularExpressions;

namespace Palindrome_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text wit palindromes (qnnq, aa, masam and so on...): ");
            string input = Console.ReadLine();

            string pattern = @"(.)(?:(.)(?:(.)\3?)?\2)?\1";
            Regex regEx = new Regex(pattern);

            MatchCollection matches = regEx.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
