﻿using System;

namespace Conditionals
{
    class Program
    {
        const double COG_COST = 79.99;
        const double GEAR_COST = 250.00;
        const double FULL_MARKUP_PERCENTAGE = 0.15;
        const double DISCOUNT_MARKUP_PERCENTAGE = 0.125;
        const double TAX = .089;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Non-Procedural Programming Sales Department");
            Console.WriteLine("How many cogs do you want to purchase?");
            string answer = Console.ReadLine();

            int cogs, gears;

            if(int.TryParse(answer, out cogs)==false)
            {
                Console.WriteLine("Invalide number for cogs. Goodbye.");
                Environment.Exit(-5);
            }
            Console.WriteLine("How many gears do you want to purchase?");
            answer = Console.ReadLine();

          

            if (int.TryParse(answer, out gears) == false)
            {
                Console.WriteLine("Invalide number for gears. Goodbye.");
                Environment.Exit(-5);
            }

            double totalCost, discountAmount, taxAmount;

            totalCost = (cogs * COG_COST) + (gears * GEAR_COST);
            double markupPercent;

            if (cogs >= 10 || gears >= 10 || (gears + cogs) >= 16) 
            {
                totalCost = (cogs * COG_COST) * DISCOUNT_MARKUP_PERCENTAGE + (gears * GEAR_COST) * DISCOUNT_MARKUP_PERCENTAGE;
                discountAmount = totalCost * FULL_MARKUP_PERCENTAGE - totalCost * DISCOUNT_MARKUP_PERCENTAGE;
            }
            else
            {
                discountAmount = 0;
                totalCost = (cogs * COG_COST) * FULL_MARKUP_PERCENTAGE + (gears * GEAR_COST) * FULL_MARKUP_PERCENTAGE;
            }

            double tax = totalCost * TAX;
            totalCost += tax;

            Console.WriteLine($" Cogs @ {COG_COST.ToString("C")}*{cogs.ToString("NO")} ={ (cogs*COG_COST).ToString("C2")}");
            Console.WriteLine($" Gears @ {GEAR_COST.ToString("C")}*{gears.ToString("NO")} ={ (gears * GEAR_COST).ToString("C2")}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Total Cost: {totalCost.ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Gray;

            if (discountAmount>0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine($"Discount:{discountAmount.ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Sales Tax :{tax.ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Gray;


        }
    }
}
