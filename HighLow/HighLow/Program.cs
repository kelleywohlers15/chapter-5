using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 100);
            int userEntry;
            int tries = 0;
            bool again = true;
            while (again)
            {
                Console.WriteLine("Please enter anumber between 1 - 100!");
                userEntry = Convert.ToInt32(Console.ReadLine());
                if (userEntry > r)
                {
                    Console.WriteLine("That number is to high");
                }
                else if (userEntry < r)
                {
                    Console.WriteLine("That number is to low");
                }
                else if (userEntry == r)
                {
                    Console.WriteLine("You won");
                }
                tries = tries + 1;
                if (tries == 6)
                {
                    Console.WriteLine("You had to manyto many tries" + tries);
                    again = false;
                }
            }
        }
    }
}
