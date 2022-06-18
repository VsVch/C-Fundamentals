using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrOdd = new int[n];
            int[] arrEven = new int[n];
            for (int i = 0; i < n; i++)
            {

                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arrEven[i] = numbers[1];
                    arrOdd[i] = numbers[0];
                    
                    
                }
                else
                {
                    
                    arrEven[i] = numbers[0];
                    arrOdd[i] = numbers[1];


                }

            }
            Console.WriteLine(string.Join(" ", arrOdd));
            Console.WriteLine(string.Join(" ", arrEven));
            
        }
    }
}
