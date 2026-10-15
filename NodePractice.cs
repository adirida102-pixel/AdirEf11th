using System;
using System.Collections.Generic;
using System.Text;

namespace AdirEf11th
{
    public class NodePractice
    {
        public void Run()
        {
            Node<int> josh = new Node<int>(17);
            Node<string> kosh = new Node<string>("Josh");
            Node<object> bcm = new Node<object>("Josh");
            bcm.SetNext(new Node<object>(17));
        }
    }
}
