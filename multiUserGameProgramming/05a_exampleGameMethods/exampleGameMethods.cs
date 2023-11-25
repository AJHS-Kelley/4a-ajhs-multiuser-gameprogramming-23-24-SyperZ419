// Xavier Oliver, Template, v0.3
using System;

namespace ExampleGameMethods
{
    class ExampleGameMethods
    {
        static string ChooseEnemy() // Chooses a random enemy from an array. No parameters.
        {
            Random rndNum = new Random();
            string[] enemyList = {"Goblin", "Goblin Chief", "Orc", "Skeleton", "Dragon", "Slime", "Yamato-no-Orochi", "Hydra", "Dark Warlock"}; // List of Potential Enemies
            string enemy = enemyList[rndNum.Next(0, enemyList.Length - 1)];
            Console.WriteLine("You have encountered a " + enemy + "!");
            return enemy; // Returns chosen enemy
        }

        static int[] GenerateStats() // Generates player stats. No parameters.
        {
            Random rndNum = new Random();
            //int i = 0;
            int[] stats = {1, 2, 3, 4, 5};
            //while (i < 5) {
            stats[0] = (rndNum.Next(1, 30)); // Strength
            stats[1] = (rndNum.Next(1, 30)); // Defense
            stats[2] = (rndNum.Next(1, 30)); // Speed
            stats[3] = (rndNum.Next(1, 30)); // Accuracy
            stats[4] = (rndNum.Next(1, 15)); // Luck
            Console.WriteLine("Strength: " + stats[0]);
            Console.WriteLine("Defense: " + stats[1]);
            Console.WriteLine("Speed: " + stats[2]);
            Console.WriteLine("Accuracy: " + stats[3]);
            Console.WriteLine("Luck: " + stats[4]);
            return stats; // Returns array of stats.
        }

        /*static void MethodThree()
        {
            pass;
        }

        static void MethodFour()
        {
            pass;
        }*/






        
        static void Main(string[] args)
        {
            int[] stats = GenerateStats();
            ChooseEnemy();
        }

        




    }
}