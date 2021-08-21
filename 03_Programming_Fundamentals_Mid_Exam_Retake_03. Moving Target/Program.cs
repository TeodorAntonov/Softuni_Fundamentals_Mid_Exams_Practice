using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceTargets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;

            while (command != "End")
            {
                command = Console.ReadLine();
                string[] cmd = command.Split().ToArray();

                if (cmd[0] == "Shoot")
                {
                    int index = int.Parse(cmd[1]);
                    int power = int.Parse(cmd[2]);

                    if (index >= 0 && index < sequenceTargets.Count)
                    {
                        if (sequenceTargets[index] > power)
                        {
                            sequenceTargets[index] -= power;
                        }
                        else
                        {
                            sequenceTargets.Remove(sequenceTargets[index]);
                        }
                    }
                }

                if (cmd[0] == "Add")
                {
                    int index = int.Parse(cmd[1]);
                    int value = int.Parse(cmd[2]);

                    if (index >= 0 && index < sequenceTargets.Count)
                    {
                        sequenceTargets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }

                if (cmd[0] == "Strike")
                {
                    int index = int.Parse(cmd[1]);
                    int radius = int.Parse(cmd[2]);

                    if (index - radius >= 0 && index + radius < sequenceTargets.Count)
                    {
                        sequenceTargets.RemoveRange(index - radius, (index + radius) - (index - radius) + 1);
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                }
            }
            Console.WriteLine(string.Join("|", sequenceTargets));
        }
    }
}
