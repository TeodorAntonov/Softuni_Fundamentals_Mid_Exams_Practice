using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            double priceSum = 0;

            bool isSpecial = false;

            while ((command != "special") || (command != "regular"))
            {
                command = Console.ReadLine();

                if (command == "special")
                {
                    if (priceSum <= 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }
                    isSpecial = true;
                    break;
                }
                if (command == "regular")
                {
                    if (priceSum <= 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }
                    break;
                }

                double price = double.Parse(command);

                if (price < 0)
                {
                    price = 0;
                    Console.WriteLine("Invalid price!");
                }

                priceSum += price;

            }

            double taxes = priceSum * 0.2;

            double totalPrice = priceSum + taxes;
            double totalPriceForSpecial = totalPrice - (totalPrice * 0.10);


            if (isSpecial)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceSum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPriceForSpecial:f2}$");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceSum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
