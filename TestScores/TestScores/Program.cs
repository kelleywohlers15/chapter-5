using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int entry = 0;
            int count = 0;
            int average;

            while (entry != 999)
            {
                Console.WriteLine("Please enter test scores");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;
                count++;
            }
            average = total / count;
            Console.WriteLine(average);




         



        }
    }
}
