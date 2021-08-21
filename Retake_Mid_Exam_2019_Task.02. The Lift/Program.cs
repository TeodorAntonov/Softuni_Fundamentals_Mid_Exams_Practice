using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;


namespace The_LIft
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {

                while (wagons[i] < 4)
                {
                    if (people <= 0)
                    {
                        break;
                    }

                    people--;
                    wagons[i]++;
                }
                //if (people >= 4 && wagons[i] == 0)
                //{
                //    wagons[i] = 4;
                //    people -= 4;
                //}
                //else if (people < 4 && wagons[i] == 0)
                //{
                //    wagons[i] = people;
                //}

                //else if (people >= 4 && wagons[i] > 0)
                //{
                //    people += wagons[i];
                //    wagons[i] = wagons[i] + (4 - wagons[i]);
                //    people -= 4;
                //}

            }

            double avg = Queryable.Average(wagons.AsQueryable());

            if (avg != 4)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));

            }

            else if (people > 0 && avg == 4)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }

            else if (wagons.All(w => w == 4))
            {
                Console.WriteLine(string.Join(" ", wagons));
            }

        }
    }
}
