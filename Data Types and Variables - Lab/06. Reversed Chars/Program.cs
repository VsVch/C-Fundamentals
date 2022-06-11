using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        private static object stringInput;

        static void Main(string[] args)
        {

            {
                // Reverse using While loop  
                string reversestring = "";
                int length;

                length = stringInput.Length - 1;

                while (length >= 0)
                {
                    reversestring = reversestring + stringInput[length];
                    length--;
                }
                Console.WriteLine(reversestring);

                Console.ReadLine();

            }
        }
    }
}
