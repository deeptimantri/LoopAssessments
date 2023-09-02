using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
     class Pattern11
    {
        static void Main(string[] args)
        {
            int i, j;
            int n = 10;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write((char)(i + 64));

                }

                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
