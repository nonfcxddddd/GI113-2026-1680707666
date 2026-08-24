using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weerapat
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Current HP: {currentHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            int hpPercent = currentHp * 100 / maxHp;

            Console.WriteLine();
            Console.WriteLine($"HP Percent: {hpPercent}%");

            Console.WriteLine();
            Console.WriteLine($"{bossName} takes 60 damage!");
            currentHp = currentHp - 60;

            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");


            //character 1 kirito
            string CharacterName = "Leon";
            int CharacterHp = 180;
            float CharacterAttack = 35.5f;
            char CharacterRank = 'A';
            double CharacterCritChance = 0.25;
            bool CharacterHasShield = true;

            Console.WriteLine("=== kirito ===");
            Console.WriteLine($"Name: {CharacterName}");
            Console.WriteLine($"HP: {CharacterHp}");
            Console.WriteLine($"Attack: {CharacterAttack}");
            Console.WriteLine($"Rank: {CharacterRank}");
            Console.WriteLine($"Critical Chance: {CharacterCritChance}");
            Console.WriteLine($"Has Shield: {CharacterHasShield}");

            //character 2 asuna
            string CharacterName2 = "Asuna";
            int CharacterHp2 = 150;
            float CharacterAttack2 = 30.0f;
            char CharacterRank2 = 'B';
            double CharacterCritChance2 = 0.20;
            bool CharacterHasShield2 = true;

            Console.WriteLine("=== asuna ===");
            Console.WriteLine($"Name: {CharacterName2}");
            Console.WriteLine($"HP: {CharacterHp2}");
            Console.WriteLine($"Attack: {CharacterAttack2}");
            Console.WriteLine($"Rank: {CharacterRank2}");
            Console.WriteLine($"Critical Chance: {CharacterCritChance2}");
            Console.WriteLine($"Has Shield: {CharacterHasShield2}");

            //character 3 leafa
            string CharacterName3 = "Leafa";
            int CharacterHp3 = 160;
            float CharacterAttack3 = 32.0f;
            char CharacterRank3 = 'B';
            double CharacterCritChance3 = 0.22;
            bool CharacterHasShield3 = true;

            Console.WriteLine("=== leafa ===");
            Console.WriteLine($"Name: {CharacterName3}");
            Console.WriteLine($"HP: {CharacterHp3}");
            Console.WriteLine($"Attack: {CharacterAttack3}");
            Console.WriteLine($"Rank: {CharacterRank3}");
            Console.WriteLine($"Critical Chance: {CharacterCritChance3}");
            Console.WriteLine($"Has Shield: {CharacterHasShield3}");

            //character 4 sinon
            string CharacterName4 = "Sinon";
            int CharacterHp4 = 170;
            float CharacterAttack4 = 33.5f;
            char CharacterRank4 = 'A';
            double CharacterCritChance4 = 0.23;
            bool CharacterHasShield4 = true;

            Console.WriteLine("=== sinon ===");
            Console.WriteLine($"Name: {CharacterName4}");
            Console.WriteLine($"HP: {CharacterHp4}");
            Console.WriteLine($"Attack: {CharacterAttack4}");
            Console.WriteLine($"Rank: {CharacterRank4}");
            Console.WriteLine($"Critical Chance: {CharacterCritChance4}");
            Console.WriteLine($"Has Shield: {CharacterHasShield4}");

            //character 5 yuuki
            string CharacterName5 = "Yuuki";
            int CharacterHp5 = 140;
            float CharacterAttack5 = 28.0f;
            char CharacterRank5 = 'C';
            double CharacterCritChance5 = 0.18;
            bool CharacterHasShield5 = true;

            Console.WriteLine("=== yuuki ===");
            Console.WriteLine($"Name: {CharacterName5}");
            Console.WriteLine($"HP: {CharacterHp5}");
            Console.WriteLine($"Attack: {CharacterAttack5}");
            Console.WriteLine($"Rank: {CharacterRank5}");
            Console.WriteLine($"Critical Chance: {CharacterCritChance5}");
            Console.WriteLine($"Has Shield: {CharacterHasShield5}");
        }
    }
}
