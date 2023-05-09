using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpapter05_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("반복 횟수를 입력하세요 :");
            int input = int.Parse(Console.ReadLine());

            if (input <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
            }

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}