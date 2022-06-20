using System;
using System.Linq;
using System.Text;

namespace Lab_Arr_Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            //string input = Console.ReadLine();

            string result = StringRepeat(input, n);
            Console.Write(result);
        }

        private static string StringRepeat(string input, int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(input);
            }
            return result.ToString();
        }
    }
}