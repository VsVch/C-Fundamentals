using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //double V, Width, Height, Length = 0;
            Console.Write("Length: ");
            double Length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double Height = double.Parse(Console.ReadLine());
            double V = (Width * Height * Length) / 3;
            
            Console.WriteLine($"Pyramid Volume: {V:f2}");

        }
    }
}
