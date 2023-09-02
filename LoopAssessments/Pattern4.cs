using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
     class Pattern4
    {
        static void Main(string[] args)
        {
            int val = 7;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    // Console.Write(" ");  
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
