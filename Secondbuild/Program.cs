using System;

namespace Secondbuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User. On a scale of 1 to 10, how are you today?");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 5)
            {
                Console.WriteLine("Sorry to hear that. Hope it gets better soon.");
            }
            else if (num > 10)
            {
                Console.WriteLine("Excellent! That's amazing to hear.");
            }
            else
            {
                Console.WriteLine("That's good to hear!");
            }
        } 

    }
}
