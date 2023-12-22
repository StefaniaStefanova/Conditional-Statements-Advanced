using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double s = double.Parse(Console.ReadLine());
            double trade = 0;
            if (town == "Sofia")
            {
                if (0 <= s && s <= 500)
                    trade = 0.05;

                if (500 < s && s <= 1000)
                    trade = 0.07;
                if (1000 < s && s <= 10000)
                    trade = 0.08;
                if (s > 10000)
                    trade = 0.12;
                double allsum = trade * s;
                Console.WriteLine($"{allsum:f2}");

            }
            else if (town == "Plovdiv")
            {
                if (0 <= s && s <= 500)
                    trade = 0.055;

                if (500 < s && s <= 1000)
                    trade = 0.08;
                if (1000 < s && s <= 10000)
                    trade = 0.12;
                if (s > 10000)
                    trade = 0.145;
                double allsum = trade * s;
                Console.WriteLine($"{allsum:f2}");





            }
            else if (town == "Varna")
            {
                if (0 <= s && s <= 500)
                    trade = 0.045;

                if (500 < s && s <= 1000)
                    trade = 0.075;
                if (1000 < s && s <= 10000)
                    trade = 0.1;
                if (s > 10000)
                    trade = 0.13;
                double allsum = trade * s;
                Console.WriteLine($"{allsum:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
