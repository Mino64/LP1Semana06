using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(args[0]);
            int s = Convert.ToInt32(args[1]);

            Random rando = new Random(s);

           int sum = 0;

            for(int i = 0; i < n; i++)
            {
                
                int temp = rando.Next(1,7);

                sum += temp;
                Console.WriteLine($"current calc{sum}");

            }
            Console.WriteLine($"{sum}");
        }
    }
}
