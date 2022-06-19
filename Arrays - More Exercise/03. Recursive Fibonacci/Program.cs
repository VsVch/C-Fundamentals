using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] fib = new int[50];
        fib[0] = 1;
        fib[1] = 1;
        if (num > 2)
        {
            for (int i = 2; i < num; i++)
            {
                fib[i] = fib[i - 1] + fib[i-2];

            }



        }

        Console.WriteLine(fib[num-1]);
    }
}