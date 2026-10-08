using System;
using System.Collections.Generic;
using System.Text;

namespace AdirEf11th
{
    public class UnitTest
    {
        public static void Run()
        {
            //Test1();
            TestLinkedList();
        }
        
        public static void Test1()
        {
            IntNode n1 = new IntNode(-17);
            IntNode n = new IntNode(17, n1);
            n1 = null;
            Console.WriteLine(n1);
            Console.WriteLine(n);
            Console.WriteLine(n.GetNext());
        }

        public static void TestLinkedList()
        {
            IntNode n1 = new IntNode(42);
            IntNode n2 = new IntNode(3);
            n1.SetNext(n2);
            IntNode n3 = new IntNode(51);
            n2.SetNext(n3);
            n2 = null;
            n3 = null;

            Console.WriteLine(n1);
            Console.WriteLine(n1.GetNext());
            Console.WriteLine(n1.GetNext().GetNext());
            Console.WriteLine();

            IntNode n4 = new IntNode(99);
            n1.GetNext().GetNext().SetNext(n4);
            n4 = null;

            Console.WriteLine(n1);
            Console.WriteLine(n1.GetNext());
            Console.WriteLine(n1.GetNext().GetNext());
            Console.WriteLine(n1.GetNext().GetNext().GetNext());
            Console.WriteLine();

            n1.GetNext().GetNext().SetNext(null);
            Console.WriteLine(n1);
            Console.WriteLine(n1.GetNext());
            Console.WriteLine(n1.GetNext().GetNext());
            //Console.WriteLine(n1.GetNext().GetNext().GetNext());
            Console.WriteLine();
        }
    }
}
