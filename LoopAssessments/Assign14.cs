using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
     class Assign14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int num = Convert.ToInt32(Console.ReadLine());
            string numStr = num.ToString();
            int length = numStr.Length;
            int divide = 0, sum = 0, copy = num;
            while (copy > 0)
            {
                divide = copy % 10;
                sum = sum + (int)Math.Pow(divide, length);
                length--;
                copy = copy / 10;
            }
            if (sum == num)
                Console.WriteLine("Disarium Number.");
            else
                Console.WriteLine("Not a Disarium Number.");
            Console.ReadLine();
        }
    }
}
