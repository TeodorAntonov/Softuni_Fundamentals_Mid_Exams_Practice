using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = int.Parse(Console.ReadLine());

            double gatherPluderForTheDays = 0;

            for (int i = 1; i <= daysOfPlunder; i++)
            {
                gatherPluderForTheDays += dailyPlunder;

                if (i % 3 == 0)
                {
                    gatherPluderForTheDays += dailyPlunder * 0.5;
                }
                if (i % 5 == 0)
                {
                    gatherPluderForTheDays -= gatherPluderForTheDays * 0.3;
                }
            }

            if (gatherPluderForTheDays >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {gatherPluderForTheDays:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {(gatherPluderForTheDays / expectedPlunder) * 100:f2}% of the plunder.");
            }
        }
    }
}