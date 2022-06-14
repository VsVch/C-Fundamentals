

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBeer = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;  
            string modelBeer = "";
            string biggestBeer = "";
            for (int i = 1; i <= numBeer; i++)
            {
                modelBeer = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeKeg = Math.PI * radius * radius * height;
                if (volumeKeg > biggestKeg)
                {
                    biggestKeg = volumeKeg;
                    biggestBeer = modelBeer;
                }
            }
            Console.WriteLine(biggestBeer);
        }
    }
}
