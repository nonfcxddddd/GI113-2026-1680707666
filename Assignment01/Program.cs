/*
 * Student ID : 1680707666
 * Name       : WEERAPAT PROMPAT
 * Section    : 129A
 * No.        : 8
 * Course     : GI113 Computer Programming (GI)
 */
using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "GLOOMLADLE: SOUP OF THE LOST";

            string chefName = "Zibblequork";
            char chefRank = 'B';
            int chefLevel = 12;
            int orderCapacity = 6;
            float cookingSpeed = 1.25f;
            double soulEnergy = 76.8;
            bool isCoopReady = true;

            var signatureDish = "Whispering Comet Broth";
            var partnerName = "Murkspoon IX";

            // Implicit conversion: int to double, without a cast.
            double chefLevelAsDouble = chefLevel;

            // The same energy value is displayed in two whole-number styles.
            int soulEnergyTruncated = (int)soulEnergy;
            int soulEnergyRounded = Convert.ToInt32(soulEnergy);

            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine($"| {GameTitle,-64} |");
            Console.WriteLine("| CHEF PASSPORT                           UNDERWORLD NIGHT SHIFT   |");
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine($"| Chef             : {chefName,-45} |");
            Console.WriteLine($"| Kitchen rank     : {chefRank,-45} |");
            Console.WriteLine($"| Chef level       : {chefLevel,-45} |");
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("| SERVICE STATS                                                    |");
            Console.WriteLine($"| Order capacity   : {orderCapacity,-45} |");
            Console.WriteLine($"| Cooking speed (x): {cookingSpeed,-45:F2} |");
            Console.WriteLine($"| Soul energy (pts): {soulEnergy,-45:F1} |");
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("| TWO-CHEF TEAM                                                    |");
            Console.WriteLine($"| Partner          : {partnerName,-45} |");
            Console.WriteLine($"| Co-op ready      : {isCoopReady,-45} |");
            Console.WriteLine($"| Signature dish   : {signatureDish,-45} |");
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("| STAT DISPLAY PREVIEW                                             |");
            Console.WriteLine($"| Level as double  : {chefLevelAsDouble,-45:F1} |");
            Console.WriteLine($"| Energy (precise) : {soulEnergy,-45:F1} |");
            Console.WriteLine($"| Energy (cast)    : {soulEnergyTruncated,-45} |");
            Console.WriteLine($"| Energy (Convert) : {soulEnergyRounded,-45} |");
            Console.WriteLine("| Cast drops the fraction; Convert rounds this value up.           |");
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("| Grow ingredients. Cook together. Feed lost souls.                |");
            Console.WriteLine("+------------------------------------------------------------------+");
        }
    }
}
