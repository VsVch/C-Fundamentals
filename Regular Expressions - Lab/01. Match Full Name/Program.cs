using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex patten = new Regex(regex);
            MatchCollection mathe = patten.Matches(input);
            //List result = new List(mathe);
            foreach (Match item in mathe)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
