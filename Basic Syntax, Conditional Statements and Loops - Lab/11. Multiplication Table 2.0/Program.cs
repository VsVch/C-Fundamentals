﻿using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times <= 10)
            {

                for (int i = times; i <= 10; i++)
                {
                   
                    {
                        Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
                        times++;
                    }
                    

                }
            }
            else 
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
            }


        }
    }
}
