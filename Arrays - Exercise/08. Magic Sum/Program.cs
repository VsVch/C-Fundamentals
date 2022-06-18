using System;
using System.Linq;

namespace _08_MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length-1; i++)
            {

                for (int j = arr.Length-1; j >i ; j--)
                {
                    if ((arr[i] + arr[j]) == number)
                    {
                        Console.Write($"{arr[i]} {arr[j]}");
                        Console.WriteLine();
                    }
                }
                
               
            }






        }
    }
}