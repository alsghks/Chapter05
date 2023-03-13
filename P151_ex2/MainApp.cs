using System;

namespace P151_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if(number > 0 )
            {
                if (number >= 90)
                {
                    Console.WriteLine($"입력하신 점수 {number}은(는) A학점입니다");
                }

                else if (number >= 80)
                {
                    Console.WriteLine($"입력하신 점수 {number}는(은) B학점입니다.");
                }
                else if (number >= 70)
                {
                    Console.WriteLine($"입력하신 점수 {number}는(은) C학점입니다.");
                }
                if (number < 70)
                {
                    Console.WriteLine($"입력하신 점수 {number}는(은) F학점입니다.");
                }
            }
        }
    }
}
