using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int totalD;
            int totalE;
            int totalF;
            int salesEntry;
            

            if (salesEntry == 'D')
            {
                Console.WriteLine("Enter sales >>>");
                salesEntry = Convert.ToInt32(Console.ReadLine());
                totalD = totalD + salesEntry;
            }
            else if (salesEntry == 'E') {
                Console.WriteLine("Enter sales >>>");
                salesEntry = Convert.ToInt32(Console.ReadLine());
                totalE == totalE + salesEntry;
            }
            else if (salesEntry == 'F'){
                Console.WriteLine("Enter sales >>>");
            }




        }
    }
}
