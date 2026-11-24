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
            stk.Push(1);
            stk.Push(10);
            stk.Push(17);
            stk.Push(17);
            stk.Push(37);
            stk.Push(71);
            stk.Push(102);
            Console.WriteLine(Question5(stk));
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
    }
}
