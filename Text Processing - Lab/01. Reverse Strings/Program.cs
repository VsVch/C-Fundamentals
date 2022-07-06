using System;
using System.Linq;
using System.Text;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word != "end")
            {
                string wordReverse = new string(word.Reverse().ToArray());
                Console.WriteLine($"{word} = {wordReverse}");
                word = Console.ReadLine();
            }
            

        }
    }
}
