using System;
using System.Collections.Generic;
using System.Text;

namespace AdirEf11th
{
    public class StackPractice
    {
        public static void StackPractice_UT()
        {
            Stack<int> stk = new Stack<int>();
            Stack<string> stks = new Stack<string>();

            stk.Push(1);
            stk.Push(10);
            stk.Push(21);
            stk.Push(17);
            stk.Push(7);
            stk.Push(71);
            stk.Push(102);

            stks.Push("url1");
            //TODO: Question 7 unit test

            //Console.WriteLine(Question5(stk));
            //Console.WriteLine(stk);
            //Console.WriteLine(Question6(stk));
        }

        public static Stack<int> CopyStack(Stack<int> stk)
        {
            Stack<int> temp = new Stack<int>();
            Stack<int> copyStk = new Stack<int>();
            int val;

            while (!stk.IsEmpty())
            {
                temp.Push(stk.Pop());
            }

            while (!temp.IsEmpty())
            {
                val = temp.Top();
                copyStk.Push(val);
                stk.Push(temp.Pop());
            }

            return copyStk;
        }
        
        public static bool SearchS(Stack<int> stk, int x)
        {
            Stack<int> copyStk = CopyStack(stk);
            while (!stk.IsEmpty())
            {
                if (stk.Pop() == x)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool Search(Stack<int> stk, int x)
        {
            Stack<int> temp = new Stack<int>();
            bool b = false;
            int a;

            while (!stk.IsEmpty() && !b)
            {
                a = stk.Pop();
                if (x == a)
                {
                    b = true;
                }
                temp.Push(a);
            }

            while (!temp.IsEmpty())
            {
                stk.Push(temp.Pop());
            }

            return b;
        }

        public static bool Question5(Stack<int> s)
        {
            int val1 = s.Top();
            int val2 = s.Top();
            bool con = true;

            while (!s.IsEmpty())
            {
                s.Pop();
                if (!s.IsEmpty())
                {
                    val2 = s.Top();
                    con = con && val1 >= val2;
                    val1 = s.Top();
                }
            }

            return con;
        }

        public static Stack<int> Question6(Stack<int> stk)
        {
            int num;
            Stack<int> rev = new Stack<int>();
            Stack<int> newStk = new Stack<int>();

            if (!stk.IsEmpty())
            {
                num = stk.Pop();
                while (!stk.IsEmpty())
                {
                    rev.Push(stk.Pop());
                }
                rev.Push(num);

                while (!rev.IsEmpty())
                {
                    newStk.Push(rev.Pop());
                }
            }
            return newStk;
        }

        public static string Question7(Stack<string> urls, string option)
        {
            string urlResult = "";
            int x;
            
            if (option == "Back")
            {
                if (!urls.IsEmpty())
                {
                    urls.Pop();
                    urlResult = urls.Top();
                }
            }

            else if (option == "BackX")
            {
                Console.Write("Enter X: ");
                x = int.Parse(Console.ReadLine());

                for (int i = 0; i < x; i++)
                {
                    if (!urls.IsEmpty())
                    {
                        urls.Pop();
                    }
                }

                if (!urls.IsEmpty())
                {
                    urlResult = urls.Top();
                }
            }

            return urlResult;
        }
    }
}
