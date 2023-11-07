// Xavier Oliver, MethodsParameters, v0.5
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

        // Using Defaults for Parameters
        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I am going to cook " + num + " hamburger(s).\n");
        }

        // Named Arguments
        static void AllMyChildren(string child1, string child2, string child3)
        {
            Console.WriteLine("My favorite child is " + child3);
        }

        // Method Overloading
        // Find Sum of Int
        static int FindSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }

        // Find Sum of Double
        static double FindSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }


        static void Main(string[] args)
        
        {
            //MyMethod();
            //DoubleUp();
            //MakePancakes();
            //MakeEggs(8, "scrambled");
            //MakeBurger();
            //MakeBurger(27);
            //AllMyChildren(child3: "Kobeni", child2: "Power", child1: "Aki");
            //FindSum(3, 5); // Two Ints
            //FindSum(2.77, 8.56); // Two Doubles
            //FindSum(7, 4.78); // One of Each

        }

    }




}