using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine().Split(" ").ToList();

            string command = Console.ReadLine();

            int count = 0;

            while (command != "end")
            {

                count++;
                string[] cmd = command.Split().ToArray();

                int firstNum = Convert.ToInt32(cmd[0]);
                int secondNum = Convert.ToInt32(cmd[1]);

                if (firstNum != secondNum && firstNum >= 0 && firstNum < sequence.Count && secondNum >= 0 && secondNum < sequence.Count)
                {
                    if (sequence[firstNum] == sequence[secondNum])
                    {
                        string str = sequence[firstNum];

                        Console.WriteLine($"Congrats! You have found matching elements - {sequence[firstNum]}!");
                        sequence.RemoveAll(x => x == str);

                    }

                    else if (sequence[firstNum] != sequence[secondNum])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    string newElement = ($"-{count}a");
                    sequence.Insert((sequence.Count / 2), newElement);
                    sequence.Insert((sequence.Count / 2), newElement);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                if (sequence.Count == 0)
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    return;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
