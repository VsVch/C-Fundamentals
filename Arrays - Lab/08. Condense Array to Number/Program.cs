using System;
using System.Linq;


namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {



            var inputArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var count = inputArr.Length;
            int sum = 0;
            if (inputArr.Length == 1)
            {
                sum = inputArr[0];
                Console.WriteLine(sum);
                return;

            }
            else
            {
                while (count >= 0)
                {
                    for (int i = 0; i < count - 1; i++)
                    {
                        inputArr[i] = inputArr[i] + inputArr[i + 1];
                        //Console.Write("{0}{1}", inputArr[i], i == count - 2 ? string.Empty : " ");
                        sum = inputArr[i];

                    }


                    count--;
                   
                }
                Console.WriteLine(sum);
                return;
            }
            
            
        }
    }
}
