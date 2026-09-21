/*
 * Student ID : 1680707666
 * Name       : WEERAPAT PROMPAT
 * Section    : 129A
 * No.        : 8
 * Course     : GI113 Computer Programming (GI)
 */
using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chefHp = 80;
            int wraithHp = 60;

            Console.WriteLine("=== GLOOMLADLE: PEPPER WRAITH ===");
            Console.WriteLine("One-round turn judge: Ladle Knight vs Pepper Wraith");
            Console.WriteLine($"Ladle Knight HP: {chefHp} | Pepper Wraith HP: {wraithHp}");
            Console.WriteLine("Set your ladle heat before the strike.");
            Console.WriteLine("0-29: Weak splash | 30-69: Searing hit | 70-100: Finisher");
            Console.Write("Ladle heat (whole number, 0-100): ");
            bool heatIsNumber = int.TryParse(Console.ReadLine(), out int ladleHeat);
            Console.WriteLine();

            // Reject failed parsing and out-of-range values before judging the turn.
            if (!heatIsNumber || ladleHeat < 0 || ladleHeat > 100)
            {
                Console.WriteLine("Invalid heat. Enter a whole number from 0 to 100.");
                Console.WriteLine("Turn cancelled. Neither fighter takes damage.");
            }
            else if (ladleHeat < 30)
            {
                wraithHp -= 10;
                chefHp -= 25;
                Console.WriteLine("WEAK SPLASH: Your cold ladle deals only 10 damage.");
                Console.WriteLine("Pepper Wraith counters for 25 damage. Both survive.");
            }
            else if (ladleHeat < 70)
            {
                wraithHp -= 40;
                chefHp -= 10;
                Console.WriteLine("SEARING HIT: Your heated ladle deals 40 damage.");
                Console.WriteLine("Pepper Wraith staggers and counters for 10 damage.");
            }
            else
            {
                wraithHp -= 60;
                Console.WriteLine("SOUPERNOVA: Your blazing ladle deals 60 damage!");
                Console.WriteLine("Pepper Wraith is defeated and cannot counterattack.");
            }

            Console.WriteLine($"Final HP - Ladle Knight: {chefHp} | Pepper Wraith: {wraithHp}");
            Console.WriteLine("=== END OF ROUND ===");
        }
    }
}
