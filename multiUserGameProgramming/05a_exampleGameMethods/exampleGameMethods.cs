// Xavier Oliver, Template, v0.2
using System;

namespace ExampleGameMethods
{
    class ExampleGameMethods
    {
        static string ChooseEnemy()
        {
            Random rndNum = new Random();
            string[] enemyList = {"Goblin", "Goblin Chief", "Orc", "Skeleton", "Dragon", "Slime", "Yamato-no-Orochi", "Hydra", "Dark Warlock"}; // List of Potential Enemies
            string enemy = enemyList[rndNum.Next(0, enemyList.Length - 1)];
            Console.WriteLine("You have encountered " + enemy + " !");
            return enemy;
        }

        /*static void MethodTwo()
        {
            pass;
        }

        static void MethodThree()
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