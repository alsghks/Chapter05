using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P151_ex5
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.Write("첫번째 정수를 입력하세요 : ");
            string input1 = Console.ReadLine();
            Console.Write("두번째 정수를 입력하세요 : ");
            string input2 = Console.ReadLine();
            Console.Write("세번째 정수를 입력하세요 : ");
            string input3 = Console.ReadLine();

            int a = int.Parse(input1);
            int b = int.Parse(input2);
            int c = int.Parse(input3);

            int[] arr = { a, b, c };              
            int max = arr.Max();
            int min = arr.Min();
            int avg = (int)arr.Average();
            int sum = arr.Sum();

            Console.WriteLine($"입력하신 {a},{b},{c} 중 최대값은 {max}이며, 최소값은 {min}입니다");
            Console.WriteLine($"입력하신 {a},{b},{c} 의 합은 {sum}이며, 평균은 {avg}입니다.");

        }
    }
}

