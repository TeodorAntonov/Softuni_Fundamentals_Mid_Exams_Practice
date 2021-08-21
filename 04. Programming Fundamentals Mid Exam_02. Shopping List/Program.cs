using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine().Split("!").ToList();

            string command = string.Empty;

            while (command != "Go Shopping!")
            {
                command = Console.ReadLine();
                string[] cmd = command.Split().ToArray();

                if (cmd[0] == "Urgent")
                {
                    if (!initialList.Contains(cmd[1]))
                    {
                        initialList.Insert(0, cmd[1]);
                    }
                }

                if (cmd[0] == "Unnecessary")
                {
                    if (initialList.Contains(cmd[1]))
                    {
                        initialList.Remove(cmd[1]);
                    }
                }

                if (cmd[0] == "Correct")
                {
                    string oldItem = cmd[1];
                    string newItem = cmd[2];

                    int index = 0;

                    if (initialList.Contains(cmd[1]))
                    {
                        for (int i = 0; i < initialList.Count; i++)
                        {
                            if (initialList[i] == oldItem)
                            {
                                index = i;
                            }
                        }

                        initialList.Remove(oldItem);
                        initialList.Insert(index, newItem);
                    }
                }

                if (cmd[0] == "Rearrange")
                {
                    if (initialList.Contains(cmd[1]))
                    {
                        string reaarange = cmd[1];

                        initialList.Remove(cmd[1]);
                        initialList.Add(reaarange);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", initialList));
        }
    }
}
