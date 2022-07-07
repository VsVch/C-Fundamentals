using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            int startIndexname = input.LastIndexOf('\\');
            int startIndexpath = input.LastIndexOf('.');

            string filename = input.Substring(startIndexname + 1, startIndexpath - startIndexname - 1);
            string extention = input.Substring(startIndexpath + 1);


            Console.WriteLine($"File name: {filename}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
