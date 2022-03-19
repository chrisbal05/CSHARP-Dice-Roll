using System;

namespace Dice_Roll
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int roll = 0;
            int attempt = 0;

            Console.WriteLine("Press enter to roll the dice");

            while (roll != 6)
            {
                Console.ReadKey();
                roll = numberGen.Next(1, 7);
                Console.WriteLine("You rolled " + roll);
                attempt++;
            }

            Console.WriteLine("It took " + attempt + " attempts to roll a six!");

            // wait before closing
            Console.ReadKey();
        }
    }
}
