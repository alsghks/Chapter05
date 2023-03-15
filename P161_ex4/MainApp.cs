using System;

namespace P161_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("알고싶은 월을 입력해주세요 :  ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            switch (number)
            {
                case 3:
                case 4:
                case 5:
                    Console.Write($"{number}월은 봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write($"{number}월은 여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:                  
                    Console.Write($"{number}월은 가을입니다.");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.Write($"{number}월은 겨울입니다.");
                    break;
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실행해주세요.");
                    return;
            }
           
        }
    }
}
