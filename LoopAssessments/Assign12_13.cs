using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
     class Assign12_13
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.Write("Enter any Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
            /*1) 4! = 4 * 3 * 2 * 1 = 24
            2) 3! = 3 * 2 * 1 = 6*/
        }
    }
}
