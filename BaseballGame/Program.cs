using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    private static int[] Serializer(int pitching, bool isHuman)
    {
        int hundreds = pitching / 100;
        int tens = pitching % 100 / 10;
        int units = pitching % 100 % 10;
        if (tens * units == 0)
        {
            if (isHuman)
            {
                Console.WriteLine("0은 포함할 수 없습니다.");
            }
            return null;
        }
        else if ((pitching < 100 || pitching >= 1000) && isHuman)
        {
            Console.WriteLine("세자리 숫자를 입력해주세요.");
            return null;
        }
        else if (hundreds != tens && tens != units && units != hundreds)
        {
            return new int[] { hundreds, tens, units };
        }
        else
        {
            if (isHuman)
            {
                Console.WriteLine("각 자리수를 다르게 입력해주세요.");
            }
            return null;
        }
    }

    static void Main(string[] args)
    {
        int[] homerun;

        // Target
        do
        {
            int rand = new Random().Next(100, 1000);
            Console.WriteLine("이게 정답입니다 : " + rand);
            homerun = Serializer(rand, false);
        } while (homerun == null);
        Console.WriteLine("숫자가 정해졌습니다.");

        // Input
        while (true)
        {
            int[] swing;
            Console.Write("정답을 입력해주세요->");
            String input = Console.ReadLine();

            try
            {
                swing = Serializer(int.Parse(input), true);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("3자리 자연수를 입력해주세요. (" + fe.GetType() + ")");
                continue;
            }

            if (swing == null)
            {
                continue;
            }

            // Logic
            int ball = 0;
            int strike = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (swing[i] == homerun[j])
                        if (i == j) strike++;
                        else ball++;

            // Output
            if (strike == 3)
            {
                Console.WriteLine("HOMERUN! 정답입니다!");
                break;
            }
            else if (strike == 0 && ball == 0)
            {
                Console.WriteLine("OUT!");
            }
            else
            {
                if (strike == 0)
                {
                    Console.WriteLine(ball + " BALL");
                }
                else if (ball == 0)
                {
                    Console.WriteLine(strike + " STRIKE");
                }
                else
                {
                    Console.WriteLine(strike + " STRIKE, " + ball + " BALL");
                }
            }
        }
    }
}
