namespace _13.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type=Console.ReadLine();
            int r=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            double result = 0;
            if(type=="Premiere")
            {
                result = r * c * 12;
            }
            else if(type=="Normal")
            {
                result = r * c * 7.50;
            }
            else if(type=="Discount")
            {
                result = r * c * 5;
            }
            Console.WriteLine($"{result:F2} leva");
        }
    }
}