using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            switch (type)
            {
                case "string":
                    Console.WriteLine(GetMax(first, second));
                    break;
                case "int":
                    Console.WriteLine(GetMax1(int.Parse(first), int.Parse(second)));
                    break;
                case "char":
                    Console.WriteLine(GetMax2(char.Parse(first), char.Parse(second)));
                    break;

                default:
                    break;
            }

            static string GetMax(string first, string second)
            {
                if (first.CompareTo(second) > 0)
                {
                    return first;
                }
                else
                {
                    return second;
                }
            }
            static int GetMax1(int first, int second)
            {
                if (first > second)
                {
                    return first;
                }
                else
                {
                    return second;
                }
            }
            static char GetMax2(char first, char second)
            {
                if (first > second)
                {
                    return first;
                }
                else
                {
                    return second;
                }
            }







        }
    }
}
