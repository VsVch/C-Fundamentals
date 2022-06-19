using System;
using System.Linq;
namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int indexLeft = arr.Length / 4 - 1;
            int indexRight = 3 * arr.Length / 4;

            int[] middle = new int[arr.Length/2];
            int[] ends = new int[arr.Length/2];
            int count = 0;

            for (int i = indexLeft; i >= 0; i--)
            {
                ends[indexLeft - i] = arr[i];
                count++;
            }

            for (int j = arr.Length-1; j >= indexRight; j--)
            {
                ends[arr.Length - 1 - j + count] = arr[j];
            }

            for (int k = indexLeft + 1; k < indexRight; k++)
            {
                middle[k - count] = arr[k];
            }

            for (int m = 0; m < middle.Length; m++)
            {
                Console.Write(middle[m] + ends[m] + " ");
            }


        }
    }
}