﻿using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if (hours >= 10 && hours <= 18 && day != "Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {

                Console.WriteLine("closed");

            }
        }
    }
}