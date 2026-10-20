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

            //Question15A(lChar, 'a');
            //Question15B();
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

        //continue
    }
}
