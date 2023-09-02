using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
     class Assign1_1
    {
        static void Main(string[] args)
        {
            int i, N;
            Console.WriteLine("Enter N:");
            N = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
                Console.WriteLine( i * 10);
            }
        }
    }
}
