using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumForInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int total =0 ;
            int e = 0;
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine("Please enter a number");
                e = Convert.ToInt32(Console.ReadLine());
                total = total + e;
            }

            Console.WriteLine("Your total is " + total);
             

        }
       
    }
}
