using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 0;
            int total = 0;
            while (entry != 999) ;
            {
                Console.WriteLine("please enter a number ");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;
            }  
            Console.WriteLine(total);

        }

    }
}
