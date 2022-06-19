using System;
using System.Linq;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumVowel = 0;
            int sumCons = 0;
            int sum = 0;

            int[] sorfInt = new int[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                for (int j = 0; j < name.Length; j++)
                {
                    int currLetter = name[j];
                    if (currLetter == 97 || currLetter == 101 || currLetter == 105 || currLetter == 111 || currLetter == 117 || currLetter == 65 || currLetter == 69 || currLetter == 73 || currLetter == 79 || currLetter == 85)
                    {
                        sumVowel += currLetter * name.Length;
                    }

                    else
                    {
                        sumCons += currLetter / name.Length;
                    }

                }

                sum = sumCons + sumVowel;

                sorfInt[i] = sum;
                sum = 0;
                sumCons = 0;
                sumVowel = 0;
            }
            Array.Sort(sorfInt);
            for (int i = 0; i < sorfInt.Length; i++)
            {
                Console.WriteLine(sorfInt[i]);
            }




        }
    }
}