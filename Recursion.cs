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
            //Console.WriteLine(Question1(4));
            //Console.WriteLine(Question2(6));
            //Console.WriteLine(Question3(6));
            //Console.WriteLine(Question3(5));
            //Console.WriteLine(Question3(7));
            //Console.WriteLine(Question4(123));
            //Console.WriteLine(Question4(38222));
            //Console.WriteLine(Question5(20, 5));
            //Console.WriteLine(Question5(5, 2));
            //Console.WriteLine(Question6(5, 2));
            //Console.WriteLine(Question6(15, 4));
            //Console.WriteLine(Question7(12, 3));
            //Console.WriteLine(Question7(17, 7));
            //Console.WriteLine(Question8(7, 7));
            //Console.WriteLine(Question8(9, 9));
            //Console.WriteLine(Question8(1, 1));
            //Console.WriteLine(Question8(2, 2));
            //Console.WriteLine(Question8(3, 3));
            //Console.WriteLine(Question8(14, 14));
            //Console.WriteLine(Question9(24886));
            //Console.WriteLine(Question9(23187));
            //Console.WriteLine(Question9(21));
            //Console.WriteLine(Question9(24));
            //Console.WriteLine(Question10(3));
            //Console.WriteLine(Question10(5));
            //Console.WriteLine(Question10(6));
            //Console.WriteLine(Question11(4));
            //Console.WriteLine(Question12(20, 9, true));
            //Console.WriteLine(Question13A(5));
            //Console.WriteLine(Question13A(6));
            //Console.WriteLine(Question13A(8));
            //Console.WriteLine(Question13B(4));
            //Console.WriteLine(Question13B(6));
            //Console.WriteLine(Question13B(7));

            int[] arr = { 8, 23, 22, 12, 102, 56, 88 };
            int[] arr2 = { 3, 7, 12, 33, 76, 81, 102 };
            int[] arr3 = { 4, 12, 80, 48, 20 };
            int[,] mat = { { 3, 5, 7 }, { 5, 12, 0 }, { 9, 13, 17 } };
            //Console.WriteLine(Max(arr, 6));
            //Console.WriteLine(Question14(arr, 2));
            //Console.WriteLine(Question15(arr, 5));
            //Console.WriteLine(Question16(arr, 12));
            //Console.WriteLine(Question16(arr, 2));
            //Console.WriteLine(Question17(arr));
            //Console.WriteLine(Question17(arr2));
            //Console.WriteLine(Question18(arr2));
            //Console.WriteLine(Question18(arr3));
            //Console.WriteLine(Question19(5, mat));
        }

        public static int Question1(int n)
        {
            int sum = 0;

            if (n > 0)
            {
                sum += n + Question1(n - 1);
            }

            return sum;
        }

        public static int Question2(int n)
        {
            int result = 1;

            if (n > 0)
            {
                result *= n * Question2(n - 1);
            }

            return result;
        }

        public static int Question3(int n)
        {
            int result = 1;

            if (n > 0)
            {
                if (n % 2 == 0)
                {
                    n -= 1;
                }
                result *= n * Question3(n - 2);
            }

            return result;
        }

        public static int Question4(int num)
        {
            int digitNum = 0;

            if (num > 0)
            {
                digitNum += 1 + Question4(num / 10);
            }

            return digitNum;
        }

        public static int Question5(int num1, int num2)
        {
            int result = 0;

            if (num1 - num2 >= 0)
            {
                result += 1 + Question5(num1 - num2, num2);
            }

            return result;
        }

        public static int Question6(int num1, int num2)
        {
            int remainder = 0;

            if (num1 - num2 > 0)
            {
                remainder = Question6(num1 - num2, num2);
            }
            else
            {
                remainder = num1;
            }

            return remainder;
        }

        public static bool Question7(int x, int y)
        {
            bool dividable = false;

            if (x > 0)
            {
                dividable = Question7(x - y, y);
            }
            else if (x == 0)
            {
                dividable = true;
            }

            return dividable;
        }

        private static bool Question8(int num, int n)
        {
            bool prime = true;

            if (n == num)
            {
                n -= 1;
            }
            if (n > 1)
            {
                prime = (num % n != 0) && Question8(num, n - 1);
            }

            return prime;
        }
        public static bool Question8(int num)
        {
            return Question8(num, num);
        }

        public static bool Question9(int num)
        {
            bool condition = true;

            if (num >= 10)
            {
                condition = num % 10 % 2 == num / 10 % 10 % 2;
                condition = condition && Question9(num / 10);
            }

            return condition;
        }

        public static int Question10(int n)
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
                sum += Question10(n - 1);
            }

            return sum;
        }

        public static double Question11(int n)
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
                sum += Question11(n - 1);
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

        private static int Question16(int[] arr, int num, int index)
        {
            int resultIndex = -1;
            
            if (index < arr.Length)
            {
                if (arr[index] != num)
                {
                    resultIndex = Question16(arr, num, index + 1);
                }
                else
                {
                    resultIndex = index;
                }
            }

            return resultIndex;
        }
        public static int Question16(int[] arr, int num)
        {
            return Question16(arr, num, 0);
        }

        private static bool Question17(int[] arr, int index)
        {
            bool answer = true;
            
            if (index < arr.Length - 1)
            {
                if (arr[index + 1] > arr[index])
                {
                    answer = answer && Question17(arr, index + 1);
                }
                else
                {
                    answer = false;
                }
            }

            return answer;
        }
        public static bool Question17(int[] arr)
        {
            return Question17(arr, 0);
        }

        private static bool Question18(int[] arr, int index)
        {
            bool answer = true;
            
            if (index < arr.Length)
            {
                if (!Question8(arr[index]))
                {
                    answer = answer && Question18(arr, index + 1);
                }
                else
                {
                    answer = false;
                }
            }

            return answer;
        }
        public static bool Question18(int[] arr)
        {
            return Question18(arr, 0);
        }

        private static int Question19(int num, int[,] mat, int row)
        {
            bool foundInRow = false;
            int rowsWithNumCount = 0;
            
            if (row < mat.GetLength(0))
            {
                for (int col = 0; col < mat.GetLength(1); col++)
                {
                    if (mat[row, col] == num)
                    {
                        foundInRow = true;
                    }
                }
                if (foundInRow)
                {
                    rowsWithNumCount++;
                }
                rowsWithNumCount += Question19(num, mat, row + 1);
            }

            return rowsWithNumCount;
        }
        public static int Question19(int num, int[,] mat)
        {
            return Question19(num, mat, 0);
        }

        private static bool Question20(int[] arr, int num1, int num2)
        {
            string numStr = "";
            
            if (num1 <= num2)
            {
                numStr += num1.ToString();
            }
            //TBA
        }
        public static bool Question20(int[] arr)
        {
            int num1, num2;
            Random rnd = new Random();

            num1 = rnd.Next(0, arr.Length);
            num2 = rnd.Next(0, arr.Length);
            while (num1 == num2)
            {
                num2 = rnd.Next(0, arr.Length);
            }

            return Question20(arr, Math.Min(num1, num2), Math.Max(num1, num2));
        }
    }
}