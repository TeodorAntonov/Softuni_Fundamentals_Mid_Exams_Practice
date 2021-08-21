using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            string command = Console.ReadLine();

            int lastposition = 0;

            while (command != "Love!")
            {
                string[] cmd = command.Split().ToArray();

                string jump = cmd[0];
                int lenght = int.Parse(cmd[1]);
                lastposition += lenght;

                if (lastposition >= neighborhood.Count)
                {
                    lastposition = 0;
                }

                if (neighborhood[lastposition] > 0)
                {
                    neighborhood[lastposition] -= 2;

                    if (neighborhood[lastposition] == 0)
                    {
                        Console.WriteLine($"Place {lastposition} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {lastposition} already had Valentine's day.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {lastposition}.");

            int countZeroes = 0;
            int countNotZeroes = 0;

            foreach (var item in neighborhood)
            {
                if (item == 0)
                {
                    countZeroes++;
                }
                else
                {
                    countNotZeroes++;
                }
            }

            if (countZeroes == neighborhood.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {countNotZeroes} places.");
            }
        }
    }
}