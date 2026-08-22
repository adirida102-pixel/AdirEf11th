using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf11th
{
    public class Recursion
    {
        public static void Recursion_UT()
        {
            //Console.WriteLine(SummerQuestion1(4));
            //Console.WriteLine(SummerQuestion2(6));
            //Console.WriteLine(SummerQuestion3(6));
            //Console.WriteLine(SummerQuestion3(5));
            //Console.WriteLine(SummerQuestion3(7));
            //Console.WriteLine(SummerQuestion4(123));
            //Console.WriteLine(SummerQuestion4(38222));
            //Console.WriteLine(SummerQuestion5(20, 5));
            //Console.WriteLine(SummerQuestion5(5, 2));
            //Console.WriteLine(SummerQuestion6(5, 2));
            //Console.WriteLine(SummerQuestion6(15, 4));
            //Console.WriteLine(SummerQuestion7(12, 3));
            //Console.WriteLine(SummerQuestion7(17, 7));
        }

        public static int SummerQuestion1(int n)
        {
            int sum = 0;

            if (n > 0)
            {
                sum += n + SummerQuestion1(n - 1);
            }

            return sum;
        }

        public static int SummerQuestion2(int n)
        {
            int result = 1;

            if (n > 0)
            {
                result *= n * SummerQuestion2(n - 1);
            }

            return result;
        }

        public static int SummerQuestion3(int n)
        {
            int result = 1;

            if (n > 0)
            {
                if (n % 2 == 0)
                {
                    n -= 1;
                }
                result *= n * SummerQuestion3(n - 2);
            }

            return result;
        }

        public static int SummerQuestion4(int num)
        {
            int digitNum = 0;

            if (num > 0)
            {
                digitNum += 1 + SummerQuestion4(num / 10);
            }

            return digitNum;
        }

        public static int SummerQuestion5(int num1, int num2)
        {
            int result = 0;

            if (num1 - num2 >= 0)
            {
                result += 1 + SummerQuestion5(num1 - num2, num2);
            }

            return result;
        }

        public static int SummerQuestion6(int num1, int num2)
        {
            int remainder = 0;

            if (num1 - num2 > 0)
            {
                remainder = SummerQuestion6(num1 - num2, num2);
            }
            else
            {
                remainder = num1;
            }

            return remainder;
        }

        public static bool SummerQuestion7(int x, int y)
        {
            bool dividable = false;

            if (x > 0)
            {
                dividable = SummerQuestion7(x - y, y);
            }
            else if (x == 0)
            {
                dividable = true;
            }

            return dividable;
        }
    }
}
