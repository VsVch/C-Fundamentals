using System;
using System.Linq;

namespace _10_LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfFiled = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] newInitianalIndex = new int[sizeOfFiled];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                if (initialIndexes[i] < newInitianalIndex.Length && initialIndexes[i] >= 0)
                {
                    newInitianalIndex[initialIndexes[i]] = 1;
                }

            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] mooving = input.Split().ToArray();
                int possisionStart = int.Parse(mooving[0]);
                string direction = mooving[1];
                int possisionFly = int.Parse(mooving[2]);

                if (possisionStart < newInitianalIndex.Length && possisionStart >= 0 && newInitianalIndex[possisionStart] == 1 && possisionFly != 0)
                {


                    if (direction == "right")
                    {
                        if (possisionStart + possisionFly < newInitianalIndex.Length && possisionStart + possisionFly >= 0 && newInitianalIndex[possisionStart + possisionFly] == 0)
                        {
                            newInitianalIndex[possisionStart + possisionFly] = 1;
                        }

                        else if (possisionStart + possisionFly < newInitianalIndex.Length && possisionStart + possisionFly >= 0 && newInitianalIndex[possisionStart + possisionFly] == 1)
                        {
                            while (possisionStart + possisionFly < newInitianalIndex.Length && possisionStart + possisionFly >= 0 && newInitianalIndex[possisionStart + possisionFly] == 1)
                            {
                                possisionFly += possisionFly;
                                if (possisionStart + possisionFly < newInitianalIndex.Length && possisionStart + possisionFly >= 0 && newInitianalIndex[possisionStart + possisionFly] == 0)
                                {
                                    newInitianalIndex[possisionStart + possisionFly] = 1;
                                    break;
                                }
                            }


                        }


                    }

                    else if (direction == "left")
                    {

                        if (possisionStart - possisionFly >= 0 && possisionStart - possisionFly < newInitianalIndex.Length && newInitianalIndex[possisionStart - possisionFly] == 0)
                        {
                            newInitianalIndex[possisionStart - possisionFly] = 1;
                        }

                        else if (possisionStart - possisionFly >= 0 && possisionStart - possisionFly < newInitianalIndex.Length && newInitianalIndex[possisionStart - possisionFly] == 1)
                        {
                            while (possisionStart - possisionFly >= 0 && possisionStart - possisionFly < newInitianalIndex.Length && newInitianalIndex[possisionStart - possisionFly] == 1)
                            {
                                possisionFly += possisionFly;
                                if (possisionStart - possisionFly >= 0 && possisionStart - possisionFly < newInitianalIndex.Length && newInitianalIndex[possisionStart - possisionFly] == 0)
                                {
                                    newInitianalIndex[possisionStart - possisionFly] = 1;
                                    break;
                                }
                            }


                        }



                    }


                    newInitianalIndex[possisionStart] = 0;






                }


            }


            Console.WriteLine(string.Join(" ", newInitianalIndex));




        }
    }
}