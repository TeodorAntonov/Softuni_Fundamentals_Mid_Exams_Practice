using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string cmd = Console.ReadLine();

            int wonBattle = 0;

            while (cmd != "End of battle")
            {
                int distance = Convert.ToInt32(cmd);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattle} won battles and {energy} energy");
                    return;
                }

                energy -= distance;
                wonBattle++;

                if (wonBattle % 3 == 0)
                {
                    energy += wonBattle;
                }
                cmd = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wonBattle}. Energy left: {energy}");
        }
    }
}