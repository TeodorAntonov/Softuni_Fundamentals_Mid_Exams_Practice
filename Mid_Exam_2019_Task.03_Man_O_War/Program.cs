using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();

            int hp = int.Parse(Console.ReadLine());

            string command = string.Empty;

            while (command != "Retire")
            {
                command = Console.ReadLine();

                string[] cmd = command.Split().ToArray();

                if (cmd[0] == "Fire")
                {
                    int index = int.Parse(cmd[1]);
                    int damage = int.Parse(cmd[2]);

                    for (int i = 0; i < warShip.Count; i++)
                    {
                        if (index > warShip.Count && index <= 0)
                        {
                            break;
                        }

                        if (index == i)
                        {
                            warShip[i] -= damage;

                            if (warShip[i] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                    }
                }

                if (cmd[0] == "Defend")
                {
                    int indexStart = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    int damge = int.Parse(cmd[3]);

                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (indexStart > pirateShip.Count || endIndex > pirateShip.Count || indexStart < 0 || endIndex < 0 || damge < 0)
                        {
                            break;
                        }

                        if (i >= indexStart && i <= endIndex)
                        {
                            pirateShip[i] -= damge;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }

                    }
                }

                if (cmd[0] == "Repair")
                {
                    int index = int.Parse(cmd[1]);
                    int restoringHP = int.Parse(cmd[2]);

                    if (index > pirateShip.Count && index < 0 && restoringHP < 0)
                    {
                        break;
                    }

                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (index == i)
                        {
                            pirateShip[index] += restoringHP;

                            if (pirateShip[index] > hp)
                            {
                                pirateShip[index] = hp;
                            }
                        }

                    }
                }

                if (cmd[0] == "Status")
                {
                    int countSections = 0;
                    double sectionsForRepairing = hp - (hp * 0.8);
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        // double sectionsForRepairing = hp * 0.20;

                        if (sectionsForRepairing > pirateShip[i])
                        {
                            countSections++;
                        }
                    }

                    Console.WriteLine($"{countSections} sections need repair.");
                }

            }

            int WARSShipSum = warShip.Sum();
            int PIRATEShipSum = pirateShip.Sum();

            Console.WriteLine($"Pirate ship status: {PIRATEShipSum}");
            Console.WriteLine($"Warship status: {WARSShipSum}");
        }
    }
}
