using System;

namespace _01._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double ages = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {ages}, Grade: {averageGrade:f2}");
        }
    }
}
