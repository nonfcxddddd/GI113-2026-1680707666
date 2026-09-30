/*
 * Student ID : 1680707666
 * Name       : WEERAPAT PROMPAT
 * Section    : 129A
 * No.        : 8
 * Course     : GI113 Computer Programming (GI)
 */

using System;
using System.Globalization;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Mothglass";
            const double SmeltRate = 0.20;
            const double SalvageRate = 0.40;
            const double MaxBatch = 500;

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("=== Assignment02 ===");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate:F4} / Salvage {SalvageRate:F4}");
            Console.WriteLine("=> S / s: Smelt (Ore -> Ingot)");
            Console.WriteLine("=> B / b: Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            bool menuParsed = char.TryParse(Console.ReadLine(), out char forgeMenu);

            Console.Write("=> How much would you like: ");
            bool amountParsed = double.TryParse(Console.ReadLine(), out double batchAmount);

            if (amountParsed && batchAmount > 0 && batchAmount <= MaxBatch)
            {
                if (menuParsed && (forgeMenu == 'S' || forgeMenu == 's'))
                {
                    double ingotAmount = batchAmount * SmeltRate;
                    Console.WriteLine($"=> {batchAmount:F2} {MaterialName} Ore = {ingotAmount:F2} {MaterialName} Ingot");
                }
                else if (menuParsed && (forgeMenu == 'B' || forgeMenu == 'b'))
                {
                    double oreAmount = batchAmount / SalvageRate;
                    Console.WriteLine($"=> {batchAmount:F2} {MaterialName} Ingot = {oreAmount:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("=> Error: menu must be one letter: S, s, B, or b.");
                }
            }
            else
            {
                Console.WriteLine($"=> Error: amount must be a number greater than 0 and at most {MaxBatch:F2}.");
            }
        }
    }
}
