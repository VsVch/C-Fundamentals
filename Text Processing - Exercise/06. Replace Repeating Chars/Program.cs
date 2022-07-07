using System;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Console.ReadLine();
            test.Distinct().Select(c => c.ToString()).ToList().ForEach(c => {while (test.Contains(c + c)) test = test.Replace(c + c, c); } );
            Console.WriteLine(test);

        }
        

    }
}
