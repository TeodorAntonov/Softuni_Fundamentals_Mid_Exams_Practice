using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace _02_Programming_Fundamentals_Mid_Exam_02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrays = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string commnad = string.Empty;

            while (commnad != "end")
            {
                commnad = Console.ReadLine();

                string[] cmd = commnad.Split().ToArray();

                if (cmd[0] == "swap")
                {
                    int newNumberIndex1 = Convert.ToInt32(cmd[1]);
                    int newNumberIndex2 = Convert.ToInt32(cmd[2]);

                    int postion1 = arrays[newNumberIndex1];
                    arrays[newNumberIndex1] = arrays[newNumberIndex2];
                    arrays[newNumberIndex2] = postion1;

                }

                if (cmd[0] == "multiply")
                {
                    int newNumberIndex1 = Convert.ToInt32(cmd[1]);
                    int newNumberIndex2 = Convert.ToInt32(cmd[2]);

                    int multiply = arrays[newNumberIndex1] * arrays[newNumberIndex2];

                    arrays[newNumberIndex1] = multiply;

                }

                if (cmd[0] == "decrease")
                {

                    for (int i = 0; i < arrays.Count; i++)
                    {
                        arrays[i] -= 1;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arrays));
        }
    }
}
