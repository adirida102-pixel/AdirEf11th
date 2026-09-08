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
            //Console.WriteLine(SummerQuestion8(7, 7));
            //Console.WriteLine(SummerQuestion8(9, 9));
            //Console.WriteLine(SummerQuestion8(1, 1));
            //Console.WriteLine(SummerQuestion8(2, 2));
            //Console.WriteLine(SummerQuestion8(3, 3));
            //Console.WriteLine(SummerQuestion8(14, 14));
            //Console.WriteLine(SummerQuestion9(24886));
            //Console.WriteLine(SummerQuestion9(23187));
            //Console.WriteLine(SummerQuestion9(21));
            //Console.WriteLine(SummerQuestion9(24));
            //Console.WriteLine(SummerQuestion10(3));
            //Console.WriteLine(SummerQuestion10(5));
            //Console.WriteLine(SummerQuestion10(6));
            //Console.WriteLine(SummerQuestion11(4));
            //Console.WriteLine(SummerQuestion12(20, 9, true));
            //Console.WriteLine(SummerQuestion13A(5));
            //Console.WriteLine(SummerQuestion13A(6));
            //Console.WriteLine(SummerQuestion13A(8));
            //Console.WriteLine(SummerQuestion13B(4));
            //Console.WriteLine(SummerQuestion13B(6));
            //Console.WriteLine(SummerQuestion13B(7));

            int[] arr = { 8, 23, 22, 12, 102, 56, 88 };
            //Console.WriteLine(Max(arr, 6));
            //Console.WriteLine(Question14(arr, 2));
            //Console.WriteLine(Question15(arr, 5));
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

        public static bool SummerQuestion8(int num, int n) //the first value of n is the same as num
        {
            bool prime = true;

            if (n == num)
            {
                n -= 1;
            }
            if (n > 1)
            {
                prime = (num % n != 0) && SummerQuestion8(num, n - 1);
            }

            return prime;
        }

        public static bool SummerQuestion9(int num)
        {
            bool condition = true;

            if (num >= 10)
            {
                condition = num % 10 % 2 == num / 10 % 10 % 2;
                condition = condition && SummerQuestion9(num / 10);
            }

            return condition;
        }

        public static int SummerQuestion10(int n)
        {
            int sum = 0;

            if (n > 0)
            {
                if (n % 2 == 0)
                {
                    sum += n * n;
                }
                else
                {
                    sum += n * 2;
                }
                sum += SummerQuestion10(n - 1);
            }

            return sum;
        }

        public static double SummerQuestion11(int n)
        {
            double sum = 0;

            if (n > 0)
            {
                if (n % 2 == 0)
                {
                    sum -= Math.Sqrt(n * 2 - 1);
                }
                else
                {
                    sum += n * 2 - 1;
                }
                sum += SummerQuestion11(n - 1);
            }

            return sum;
        }

        public static int Question12(int n1, int n2, bool start)
        {
            int sum = 0;

            if (start)
            {
                n2--;
                start = false;
            }
            if (n2 > 0)
            {
                if (n1 % n2 == 0)
                {
                    sum += n2;
                }
                sum += Question12(n1, n2 - 1, start);
            }

            return sum;
        } //first value of bool start is true

        public static int Question13A(int place)
        {
            int num = 0;

            if (place == 1)
            {
                num = 0;
            }
            else if (place == 2)
            {
                num = 1;
            }
            else
            {
                num = (int)Math.Pow(Question13A(place - 2), 2) + (int)Math.Pow(Question13A(place - 1), 2);
            }

            return num;
        }

        public static int Question13B(int n)
        {
            int sum = 0;

            if (n > 0)
            {
                sum += Question13A(n);
                sum += Question13B(n - 1);
            }

            return sum;
        }

        private static int Max(int[] arr, int i)
        {
            int max = 0;

            if (i > 0)
            {
                max = Math.Max(Max(arr, i - 1), arr[i]);
            }
            else
            {
                max = arr[i];
            }

            return max;
        }
        public static int Max(int[] arr)
        {
            return Max(arr, arr.Length - 1);
        }

        public static int Question14(int[] arr, int i)
        {
            int sum = 0;

            if (i > 0)
            {
                sum += arr[i] + Question14(arr, i - 1);
            }
            else
            {
                sum += arr[i];
            }

            return sum;
        }

        public static int Question15(int[] arr, int i)
        {
            int posCount = 0;

            if (i > 0)
            {
                if (arr[i] % 2 == 0)
                {
                    posCount++;
                }
                posCount += Question15(arr, i - 1);
            }
            else
            {
                if (arr[i] % 2 == 0)
                {
                    posCount++;
                }
            }

            return posCount;
        }

        //private static int Question16(int[] arr, int num, int index) //TODO: this question and questions 17-23 for homework
        //{
            
        //}
        //public static int Question15(int[] arr, int num)
        //{

        //}
    }
}