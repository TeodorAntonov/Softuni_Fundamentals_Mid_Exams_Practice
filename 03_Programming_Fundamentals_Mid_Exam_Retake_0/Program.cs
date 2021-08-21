using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetSequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = string.Empty;

            int greterValue = int.MinValue;

            int count = 0;

            while (command != "End")
            {
                command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                int index = int.Parse(command);

                if (index >= 0 && index < targetSequence.Count)
                {
                    int keepNumber = targetSequence[index];
                    targetSequence[index] = -1;

                    for (int i = 0; i < targetSequence.Count; i++)
                    {
                        if (targetSequence[i] != -1)
                        {
                            if (keepNumber >= targetSequence[i])
                            {
                                targetSequence[i] += keepNumber;
                            }
                            else if (keepNumber < targetSequence[i])
                            {
                                targetSequence[i] -= keepNumber;
                            }
                        }
                    }
                }
            }

            foreach (var item in targetSequence)
            {
                if (item == -1)
                {
                    count++;
                }
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", targetSequence)}");
        }
    }
}
