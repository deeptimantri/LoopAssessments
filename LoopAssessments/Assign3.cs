using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignments
{
     class Assign3
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Alphabets from a - z are: ");
            for (ch = 'a'; ch <= 'z'; ch++)
            {
                //Printing all alphabets with tab
                Console.Write(ch + "\n");
            }

            Console.ReadLine();
        }
    }
}
