using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
    class Assign3_3
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int term = 1 + ((i * (i + 1)) / 2);
                Console.WriteLine(term + " ");
            }
        }
    }
}
