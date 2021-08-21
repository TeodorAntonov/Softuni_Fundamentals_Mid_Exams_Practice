using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            double emp1 = double.Parse(Console.ReadLine());
            double emp2 = double.Parse(Console.ReadLine());
            double emp3 = double.Parse(Console.ReadLine());

            double studentsAnswered = emp1 + emp2 + emp3;

            double people = int.Parse(Console.ReadLine());

            double hours = 0;
            double breaks = 0;

            while (people > 0)
            {
                hours++;
                people -= studentsAnswered;

                if (hours % 4 == 0)
                {
                    breaks++;
                }
                if (breaks > 0)
                {
                    hours += breaks;
                    breaks = 0;
                }
                if (people <= 0)
                {
                    break;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}

