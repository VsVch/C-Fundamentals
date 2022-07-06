using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            int index = second.IndexOf(first);
            while (index >= 0)
            {
                second = second.Remove(index, first.Length);
                index = second.IndexOf(first);
            }
            Console.WriteLine(second);
        }
    }
}
