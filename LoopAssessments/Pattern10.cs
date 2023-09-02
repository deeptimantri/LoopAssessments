using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
     class Pattern10
    {
        static void Main(string[] args)
        {
            int i, j;
            int n = 9;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write((char)(j + 64));

                }

                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
