// Xavier Oliver, Template, v0.2
using System;

namespace ExampleGameMethods
{
    class ExampleGameMethods
    {
        static string ChooseEnemy() // Chooses a random enemy from an array. 
        {
            Random rndNum = new Random();
            string[] enemyList = {"Goblin", "Goblin Chief", "Orc", "Skeleton", "Dragon", "Slime", "Yamato-no-Orochi", "Hydra", "Dark Warlock"}; // List of Potential Enemies
            string enemy = enemyList[rndNum.Next(0, enemyList.Length - 1)];
            Console.WriteLine("You have encountered a " + enemy + " !");
            return enemy;
        }

        static int generateStats()
        {
            Random rndNum = new Random 
            int i = 0
            int[] stats = {}
            while i < 4; i++
            stats.Append(rndNm.Next(1, 30)); // Attack
            
            Console.WriteLine(stats);
            return stats;
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
            ChooseEnemy();
        }

        




    }
}