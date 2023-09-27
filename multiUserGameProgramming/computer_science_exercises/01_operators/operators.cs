// Xavier Oliver, Template, v0.2
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Midnight";
            string food = "Soul";

            int number = 123;
            int braincells = 678;
            int kills = 23;
            int score = 45;

            float time = 12.67F;
            float depth = 456.78F;

            // Arithmetic Operators
            Console.WriteLine(number + braincells);
            Console.WriteLine(name + food);
            Console.WriteLine(time + depth);
            Console.WriteLine(number + depth);

            Console.WriteLine(number - braincells);
            //Console.WriteLine(name - food); does not apply to strings
            Console.WriteLine(time - depth);
            Console.WriteLine(number - depth);

            Console.WriteLine(number * braincells);
            //Console.WriteLine(name * food); does not apply to strings
            Console.WriteLine(time * depth);
            Console.WriteLine(number * depth);

            Console.WriteLine(number / braincells);
            //Console.WriteLine(name / food); does not apply to strings
            Console.WriteLine(time / depth);
            Console.WriteLine(number / depth);

            //Modulus
            Console.WriteLine(10 % 2);
            Console.WriteLine(9 % 4);

            //Increment
            kills = 1;
            kills++;
            Console.WriteLine(kills);

            //Decrement
            score = 2;
            score--;
            Console.WriteLine(score);

            //Assignment Operators
            // = THIS ASSIGNMENT OPERATOR THROWS OUT OLD VALUES
            braincells = 23;
            // These assignment operators keep old values
            kills += 8;
            time -= 10;
            score *= 7;
            number /= 3;

            //Comparison Operators
            Console.WriteLine(10 == 10);
            Console.WriteLine(25 > 23);
            Console.WriteLine(45 >= 44);
            Console.WriteLine(56 < 65);
            Console.WriteLine(34 <= 35);
            Console.WriteLine(123 != 77);

            //Logical Operators
            // And -- ALL CONDITIONS MUST BE TRUE FOR WHOLE STATEMENT TO BE TRUE
            Console.WriteLine(3 > 2 && 2 == 2); // True and True = True
            Console.WriteLine(3 > 2 && 5 > 6); // True and False = False        
            // Or -- ONE condition must be true for the whole statement  to be true
            Console.WriteLine(5 < 9 || 5 != 4); // True or True = True
            Console.WriteLine(9 < 10 || 3 > 5); // True or False = True
            // Not -- Find the "opposite" value
            Console.WriteLine(!(5 > 4)); // Not True = False


        }

    }




}