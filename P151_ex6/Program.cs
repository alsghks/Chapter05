using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P151_ex6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("현재 본인의 학년을 숫자만 입력하세요 : ");
            string grade = Console.ReadLine();

            Console.Write("현재 본인의 점수를 입력해주세요 : ");
            string score = Console.ReadLine();

            int a = int.Parse(grade);
            int b = int.Parse(score);

            if (a < 4)
            {
                if (b >= 60)
                    Console.WriteLine($"입력하신 점수 {b}는(은) 합격입니다.");
                else if (b < 60)
                    Console.WriteLine($"입력하신 점수 {b}는(은) 불합격입니다.");
            }
            if (a >= 4)
            {
                if (b >= 70)
                    Console.WriteLine($"입력하신 점수 {b}는(은) 합격입니다.");
                if (b < 70)
                    Console.WriteLine($"입력하신 점수 {b}는(은) 불합격입니다.");
               

            }
            
        }
    }
}
