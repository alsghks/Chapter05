using System;

namespace P161_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            
	Console.Write("월을 입력하세요 1,2,3,4,5,6,78,9,10,11,12\n ");
			string input = Console.ReadLine();
			int number = int.Parse(input);
			switch (number)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					Console.Write($"{number}월은 31일입니다");
					break;
				case 4:
				case 6:
				case 9:
				case 11:
					Console.Write($"{number}월은 30일입니다");
					break;

				case 2:
					Console.Write($"{number}월은 28일입니다");
					break;
				default:
					Console.WriteLine("정상적인 입력값이 아닙니다. 다시 입력해주세요.");
					return;
			}
        }
    }
}
