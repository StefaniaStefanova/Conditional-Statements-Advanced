using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            if ((day == "Monday") || (day == "Tuesday") || (day == "Wednesday") || (day == "Thursday") || (day == "Friday"))
            {
                if (fruit == "banana")
                    price = 2.50;

                if (fruit == "apple")
                    price = 1.20;


                if (fruit == "orange")
                    price = 0.85;


                if (fruit == "grapefruit")
                    price = 1.45;


                if (fruit == "kiwi")
                    price = 2.70;


                if (fruit == "pineapple")
                    price = 5.50;


                if (fruit == "grapes")
                    price = 3.85;



                double allsum = quantity * price;
                Console.WriteLine($"{allsum:f2}");
            }





            else if ((day == "Saturday") || (day == "Sunday"))


            {

                if (fruit == "banana")
                    price = 2.70;

                if (fruit == "apple")
                    price = 1.25;


                if (fruit == "orange")
                    price = 0.90;


                if (fruit == "grapefruit")
                    price = 1.60;


                if (fruit == "kiwi")
                    price = 3.00;


                if (fruit == "pineapple")
                    price = 5.60;


                if (fruit == "grapes")
                    price = 4.20;



                double allsum1 = quantity * price;
                Console.WriteLine($"{allsum1:f2}");
            }

            else

            {

                Console.WriteLine("error");
            }


        }
    }
}

