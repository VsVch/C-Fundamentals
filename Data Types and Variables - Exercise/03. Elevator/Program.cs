using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int count = numberPeople / capacity;
            if (numberPeople % capacity  != 0)
            {
                count++;
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(count);
            }








        }
    }
}
