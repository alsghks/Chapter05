using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_ex3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            do
            {
                int j = 0;
                while (j < i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i--;
            }
            while (i > 0);
        }
    }
}
