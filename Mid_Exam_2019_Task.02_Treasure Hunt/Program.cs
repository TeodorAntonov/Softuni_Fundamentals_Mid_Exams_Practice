using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loots = Console.ReadLine().Split('|').ToList();

            string command = string.Empty;


            while (command != "Yohoho!")
            {
                string[] cmd = command.Split().ToArray();

                if (cmd[0] == "Loot")
                {
                    for (int i = 1; i < cmd.Length; i++)
                    {
                        if (!loots.Contains(cmd[i]))
                        {
                            loots.Insert(0, cmd[i]);
                        }
                    }
                }
                if (cmd[0] == "Drop")
                {
                    int index = int.Parse(cmd[1]);

                    if (index >= 0 && index <= loots.Count - 1)
                    {
                        string addAtLastpostiong = loots[index];
                        loots.RemoveAt(index);
                        loots.Add(addAtLastpostiong);
                    }
                }

                if (cmd[0] == "Steal")
                {
                    List<string> stolenItems = new List<string>();
                    int count = int.Parse(cmd[1]);

                    int validCount = Math.Min(count, loots.Count);

                    for (int i = loots.Count - validCount; i < loots.Count; i++)
                    {
                        stolenItems.Add(loots[i]);
                    }

                    Console.WriteLine(string.Join(", ", stolenItems));
                    loots.RemoveRange(loots.Count - validCount, validCount);
                }

                command = Console.ReadLine();
            }

            if (loots.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double counterLetters = 0;
                double countLoots = 0;
                for (int i = 0; i < loots.Count; i++)
                {
                    countLoots++;
                    string str = loots[i];
                    for (int j = 0; j < str.Length; j++)
                    {
                        counterLetters++;
                    }

                }
                Console.WriteLine($"Average treasure gain: {(counterLetters / countLoots):f2} pirate credits.");
            }
        }
    }
}
