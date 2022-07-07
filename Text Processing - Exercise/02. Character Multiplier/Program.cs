using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];
            int minLenght = Math.Min(first.Length, second.Length);
            int maxLength = Math.Max(first.Length, second.Length);
            int sum = 0;
            for (int i = 0; i < minLenght; i++)
            {
                sum += first[i] * second[i];
            }
            if (first.Length != second.Length)
            {
                string longrr = first.Length > second.Length ? longrr = first : longrr = second;
                for (int i = minLenght; i < maxLength; i++)
                {
                    sum += longrr[i];
                }
            }





            Console.WriteLine(sum);

        }
    }
}
