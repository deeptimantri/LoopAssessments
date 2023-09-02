using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
    class Pattern6
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of rows");
            int input = Convert.ToInt32(Console.ReadLine());
            int temp = 1;
            for (int i = input; i >= 1; i--)
            {
                for (int j = 1; j < temp; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                temp++;
                Console.WriteLine();
            }

            }
    }
}
