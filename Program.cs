﻿using System;

namespace BA_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int myInt = 15;

            double myDouble = 25.66;

            Console.WriteLine($"INTEGER VALUE: {myInt}\nDOUBLE VALUE: {myDouble}");
            Console.WriteLine("INTEGER VALUE: " + myInt + "\n" + "DOUBLE VALUE: " + myDouble);

         // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Welcome Mr./Mrs. {name} {surname} your age is: {age}");

         // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

            int number1;
            int number2;
            int sum;

            Console.Write("Please enter the first complete number1: ");
            number1 = int.Parse(Console.ReadLine());


            Console.Write("Please enter the first complete number2: ");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine($"Sum: {sum}");

         // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

            while (true)
            {
                Console.WriteLine("Please enter your age: ");

                double number3 = double.Parse(Console.ReadLine());

                if (number3 > 90)
                {
                    Console.WriteLine("good Luck");
                }

                else
                {
                    Console.WriteLine("Your age is: " + number3);
                }
            }

         // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

        



        }

    }
}
