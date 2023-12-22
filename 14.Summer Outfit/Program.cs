namespace _14.Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees=double.Parse(Console.ReadLine());
            string time=Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (10 <= degrees&&degrees <=18) 
            {
               if(time=="Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
               else if(time=="Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if(time=="Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            if (18 < degrees && degrees <= 24)
            {
                if (time == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
                if ( degrees>=25)
                {
                    if (time == "Morning")
                    {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                    else if (time == "Afternoon")
                    {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    }
                    else if (time == "Evening")
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                }
            Console.WriteLine($"Vezi,it's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}