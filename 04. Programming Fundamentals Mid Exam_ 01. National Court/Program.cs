using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp1 = int.Parse(Console.ReadLine());
            int emp2 = int.Parse(Console.ReadLine());
            int emp3 = int.Parse(Console.ReadLine());

            int peopleForAnhour = emp1 + emp2 + emp3;

            int peopleAll = int.Parse(Console.ReadLine());

            int hour = 0;
            int breaks = 0;

            while (peopleAll > 0)
            {
                peopleAll -= peopleForAnhour;

                hour++;
                if (hour % 4 == 0)
                {
                    breaks++;
                }
                if (breaks == 1)
                {
                    hour += 1;
                    breaks = 0;
                }

                if (peopleAll < 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Time needed: {hour}h.");
        }
    }
}
