using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
     class Assign6
    {
        static void Main(string[] args)
        {
            
                int number = 0, count = 0;
                Console.Write("Enter number :");
                number = Convert.ToInt32(Console.ReadLine());
                while (number > 0)
                {
                    number = number / 10;
                    count++;
                }
                Console.WriteLine("Number of digits is : " + count);
                Console.ReadLine();
        }
    }
}
