/*
Programmer: Felipe SG
Date: 12/01/2021
Program: 5Exercise3
Objective: 
Write a program that finds the biggest of three integers, using nested
if statements.
 */

using System;

namespace _5Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double integer1, integer2, integer3, area;

            Console.WriteLine("Welcome \n");
            Console.WriteLine("Please inform the First integer: ");
            integer1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Please inform the Second integer: ");
            integer2 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Please inform the Third integer: ");
            integer3 = Convert.ToUInt32(Console.ReadLine());

            // Using nested if's 
            if (integer1 >= integer2)
            {
                if (integer1 >= integer3)
                {
                    Console.WriteLine("The biggest integer is: {0}", integer1);
                }
            }
            if (integer2 >= integer1)
            {
                if (integer2 >= integer3)
                {
                    Console.WriteLine("The biggest integer is: {0}", integer2);
                }
            }
            if (integer3 >= integer1)
            {
                if (integer3 >= integer2)
                {
                    Console.WriteLine("The biggest integer is: {0}", integer3);
                }
            }
        }
    }
}
