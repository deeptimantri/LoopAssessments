using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
     class Assign4
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter value a Number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= Number; i += 2)
            {
                sum += i;
            }
            Console.Write($"Sum of even numbers from 1 to {Number} is : {sum}");
            Console.ReadLine();
        }
    }
}
