using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrOne = Console.ReadLine().Split(" ");
            string[] arrTwo = Console.ReadLine().Split(" ");
            
            for (int j = 0; j < arrTwo.Length; j++)
            {
                for (int i = arrOne.Length-1; i >= 0; i--)
                {
                    if (arrOne[i] == arrTwo[j])
                    {
                        Console.Write($"{arrTwo[j]} ");
                        break;
                    }
                }


            }









        }
    }
}
