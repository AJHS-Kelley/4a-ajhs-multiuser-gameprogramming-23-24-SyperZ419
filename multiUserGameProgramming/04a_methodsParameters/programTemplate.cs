// Xavier Oliver, MethodsParameters, v0.3
using System;

namespace MethodsParameters
{
    class MethodsParameters
    {
        // METHOD --  named block of code, can be used over and over
        // All methods have a SIGNATURE that defines their name, parameters, and output
        // Example Signature
        static void MyMethod()
        {
            Console.WriteLine("I like mine with waffles, chicken, and eggs, with a side of hash-browns\n");
        }
        // static -- This method belongs to the current class, it is NOT and object
        // void -- This method has no return value

        static int DoubleUp()
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the next line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.WriteLine(sum);
            return sum;
        }

        // Methods with Parameters
        static void MakePancakes(int num)
        {
            for (int i = 0; i < num; i++) 
            {
                Console.WriteLine("One pancake has finished production.\n");
            }
        }

        static void MakeEggs(int num, string style)
        {
            Console.WriteLine("You have ordered " + num + " eggs cooked " + style + ".\n");
        }

        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I am going to cook " + num + " hamburger(s).\n");
        }

        static void Main(string[] args)
        
        {
            //MyMethod();
            //DoubleUp();
            //MakePancakes();
            //MakeEggs(8, "scrambled");
            MakeBurger();
            MakeBurger(27);
        }

    }




}