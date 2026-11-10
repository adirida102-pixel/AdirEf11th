using System;
using System.Collections.Generic;
using System.Text;

namespace AdirEf11th
{
    public class NodePractice
    {
        public static void Run()
        {
            //Node<int> josh = new Node<int>(17);
            //Node<string> kosh = new Node<string>("Josh");
            //Node<object> bcm = new Node<object>("Josh");
            //bcm.SetNext(new Node<object>(17));

            Node<char> lChar = new Node<char>('a');
            lChar.SetNext(new Node<char>('n'));
            lChar.GetNext().SetNext(new Node<char>('i'));
            lChar.GetNext().GetNext().SetNext(new Node<char>('A'));
            lChar.GetNext().GetNext().GetNext().SetNext(new Node<char>('d'));
            lChar.GetNext().GetNext().GetNext().GetNext().SetNext(new Node<char>('i'));
            lChar.GetNext().GetNext().GetNext().GetNext().GetNext().SetNext(new Node<char>('r'));

            Node<string> lStr = new Node<string>("yellow");
            lStr = new Node<string>("ball", lStr);
            lStr = new Node<string>("hello", lStr);
            lStr = new Node<string>("good", lStr);
            lStr = new Node<string>("dog", lStr);
            lStr = new Node<string>("cat", lStr);
            lStr = new Node<string>("apple", lStr);

            Node<int> lInt = new Node<int>(3);
            lInt = new Node<int>(19, lInt);
            lInt = new Node<int>(18, lInt);
            lInt = new Node<int>(17, lInt);
            lInt = new Node<int>(12, lInt);
            lInt = new Node<int>(102, lInt);
            lInt = new Node<int>(5, lInt);

            //Question15A(lChar, 'a');
            //Question15B();
            //Console.WriteLine(Question18(lStr, "A"));
            //Console.WriteLine(Question20(lStr).GetValue());
            /*Node<string> pp = Question21(lStr);
            if (pp != null)
            {
                Console.WriteLine(pp.GetValue());
            }
            else
            {
                Console.WriteLine("NULL!");
            }*/
            /*Node<int> tn = Question24(lInt, 1);
            if (tn != null)
            {
                Console.WriteLine(tn.GetValue());
            }
            else
            {
                Console.WriteLine("NULL!");
            }*/
            //Console.WriteLine(Question25(lInt, 3));
            Node<int> eto = Question26(lInt);
            while (eto != null)
            {
                Console.WriteLine(eto.GetValue());
                eto = eto.GetNext();
            }
        }

        public static string Print<T>(Node<T> list)
        {
            string s = "->";

            while (list != null)
            {
                s += list.ToString() + "->";
                list = list.GetNext();
            }
            s += "null";

            return s;
        }

        public static void Question15A(Node<char> list, char ch)
        {
            int count = 0;

            while (list != null)
            {
                if (list.GetValue() == ch)
                {
                    count++;
                }
                list = list.GetNext();
            }

            Console.WriteLine($"The character \'{ch}\' appears {count} times in the list.");
        }

        public static void Question15B()
        {
            Node<char> list = null;
            char ch;
            int chNum;

            Console.Write("Enter a letter: ");
            ch = char.Parse(Console.ReadLine());
            while (ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch <= 'z')
            {
                list = new Node<char>(ch, list);
                Console.Write("Enter a letter: ");
                ch = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 26 * 2 + 6; i++)
            {
                chNum = 'A' + i;
                ch = (char)chNum;
                if (i < 26 || i > 31)
                {
                    Question15A(list, ch);
                }
            }
        }

        public static int Question18(Node<string> list, string theName)
        {
            string name, firstName;
            bool flag;
            int count = 0;
            
            while (list != null)
            {
                name = list.GetValue();
                firstName = "";
                flag = true;
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] != ' ' && flag)
                    {
                        firstName += name[i];
                    }
                    else
                    {
                        flag = false;
                    }
                }
                if (firstName == theName)
                {
                    count++;
                }
                list = list.GetNext();
            }

            return count;
        }

        public static Node<string> Question20(Node<string> list)
        {
            Node<string> revList = null;
            
            while (list != null)
            {
                revList = new Node<string>(list.GetValue(), revList);
                list = list.GetNext();
            }

            return revList;
        }

        public static Node<string> Question21(Node<string> list)
        {
            Node<string> problem = null;
            bool flag = true;
            
            while (list.GetNext() != null && flag)
            {
                if (list.GetValue().CompareTo(list.GetNext().GetValue()) > 0)
                {
                    problem = list.GetNext();
                    flag = false;
                }
                list = list.GetNext();
            }

            return problem;
        }

        public static void Question22()
        {
            /*
            lst = new Node<int>(17)

              num  |  while  |     p     | return 
            --------------------------------------
               2   |  true   |(17, null) |        
            --------------------------------------
               1   |  false  |   null    |   1    
            
            
            lst = null

              num  |  while  |     p     | return 
            --------------------------------------
               2   |  false  |   null    |   2    
            
            */
        }

        public static Node<int> Question24(Node<int> list, int num)
        {
            Node<int> theNode = null;
            bool flag = true;

            while (list != null && flag)
            {
                if (list.GetValue() == num)
                {
                    theNode = list;
                    flag = false;
                }
                list = list.GetNext();
            }

            return theNode;
        }

        public static bool Question25(Node<int> lis, int num)
        {
            bool con = false;
            int folC = 0;

            while (lis.GetNext() != null)
            {
                if (lis.GetNext().GetValue() == lis.GetValue() + 1)
                {
                    folC++;
                }
                else
                {
                    if (folC >= num)
                    {
                        con = true;
                    }
                    folC = 1;
                }
                lis = lis.GetNext();
            }

            return con;
        }

        public static Node<int> Question26(Node<int> list)
        {
            Node<int> newList = null;
            Node<int> temp;
            Node<int> pos = list;
            Node<int> newHead = list;
            bool flag = false;
            
            while (pos != null)
            {
                if (pos.GetNext() != null)
                {
                    if (pos.GetNext().GetValue() % 2 == 0)
                    {
                        temp = pos.GetNext();
                        pos.SetNext(temp.GetNext());
                        newList = temp;
                        temp = null;
                        newList.SetNext(newHead);
                        newHead = newList;
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                else
                {
                    if (pos.GetValue() % 2 == 0)
                    {
                        newList = pos;
                        newList.SetNext(pos);
                        pos.SetNext(null);
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    pos = pos.GetNext();
                }
            }

            return newList;
        }
    }
}