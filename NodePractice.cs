using System;
using System.Collections.Generic;
using System.Text;

namespace AdirEf11th
{
    public class NodePractice
    {
        public void Run()
        {
            //Node<int> josh = new Node<int>(17);
            //Node<string> kosh = new Node<string>("Josh");
            //Node<object> bcm = new Node<object>("Josh");
            //bcm.SetNext(new Node<object>(17));

            Node<char> lChar = new Node<char>('a');
            lChar.SetNext(new Node<char>('n'));
            //continue unit test
        }

        public static int Question15A(Node<char> list, char ch)
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

            return count;
        }
    }
}
