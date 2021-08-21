using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace _02_Programming_Fundamentals_Mid_Exam_03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> arrays = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

            List<double> top5 = new List<double>();


            double count = 0;
            double sum = 0;


            if (arrays.Count <= 1)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = 0; i < arrays.Count; i++)
            {
                count++;
                sum += arrays[i];
            }

            double average = sum / count;

            for (int i = 0; i < arrays.Count; i++)
            {
                if (average < arrays[i])
                {
                    top5.Add(arrays[i]);
                }
            }

            if (top5.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            int countOfTop5 = 0;

            while (countOfTop5 < 5)
            {

                top5.Sort();
                top5.Reverse();

                if (top5.Count <= countOfTop5)
                {
                    break;
                }

                Console.Write(top5[countOfTop5] + " ");
                countOfTop5++;
            }
        }
    }
}
