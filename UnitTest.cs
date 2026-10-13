namespace AdirEf11th
{
    public class UnitTest
    {
        public static void Run()
        {
            //Test1();
            //TestLinkedList();

            IntNode n1 = new IntNode(4);
            IntNode n = new IntNode(12, n1);
            IntNode pos = n;
            n1 = null;
            n.GetNext().SetNext(new IntNode(3));
            n.GetNext().GetNext().SetNext(new IntNode(2));
            n.GetNext().GetNext().GetNext().SetNext(new IntNode(3));
            n.GetNext().GetNext().GetNext().GetNext().SetNext(new IntNode(11));

            //Console.WriteLine(Print(n));
            //Console.WriteLine(n);

            //Console.WriteLine(Question1(n));
            //Console.WriteLine(Question2(n));
            //Console.WriteLine(Question3(n));
            //Console.WriteLine(Question4(n));
            //Console.WriteLine(Question5(n, 17));
            //Console.WriteLine(Question6(n));

            //Console.WriteLine(MoreQuestion2(n, 3));
            //Console.WriteLine(MoreQuestion4(n));
            //Console.WriteLine(Print(n));
            //MoreQuestion5(n, 3);
            //Console.WriteLine(Print(n));
        }

        public static void Test1()
        {
            IntNode n1 = new IntNode(-17);
            IntNode n = new IntNode(17, n1);
            IntNode pos = n;
            n1 = null;
            //Console.WriteLine(n1);
            //Console.WriteLine(n);
            //Console.WriteLine(n.GetNext());
            n.GetNext().SetNext(new IntNode(55));

            string s = "->";
            while (pos != null)
            {
                s += pos.ToString() + "->";
                pos = pos.GetNext();
            }
            s += "null";
            Console.WriteLine(s);
        }

        public static string Print(IntNode lst)
        {
            string s = "->";

            while (lst != null)
            {
                s += lst.ToString() + "->";
                lst = lst.GetNext();
            }
            s += "null";

            return s;
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

        public static int Question1(IntNode lst) //count
        {
            int count = 0;

            while (lst != null)
            {
                count++;
                lst = lst.GetNext();
            }

            return count;
        }

        public static int Question2(IntNode lst)
        {
            int oddCount = 0;

            while (lst != null)
            {
                if (lst.GetValue() % 2 == 1)
                {
                    oddCount++;
                }
                lst = lst.GetNext();
            }

            return oddCount;
        }

        public static int Question3(IntNode lst)
        {
            int oddSum = 0, evenSum = 0;
            int diff;
            int val;

            while (lst != null)
            {
                val = lst.GetValue();
                if (val % 2 == 0)
                {
                    evenSum += val;
                }
                else
                {
                    oddSum += val;
                }
                lst = lst.GetNext();
            }

            diff = Math.Abs(oddSum - evenSum);

            return diff;
        }

        public static bool Question4(IntNode lst)
        {
            int posCount = 0, negCount = 0;
            bool con;
            int val;

            while (lst != null)
            {
                val = lst.GetValue();
                if (val > 0)
                {
                    posCount++;
                }
                else if (val < 0)
                {
                    negCount++;
                }
                lst = lst.GetNext();
            }

            con = posCount >= negCount;

            return con;
        }

        public static bool Question5(IntNode lst, int num)
        {
            bool con = false;

            while (lst != null)
            {
                con = con || lst.GetValue() == num;
                lst = lst.GetNext();
            }

            return con;
        }

        public static bool Question6(IntNode lst)
        {
            bool con = true;

            while (lst.GetNext() != null)
            {
                con = con && lst.GetValue() > lst.GetNext().GetValue();
                lst = lst.GetNext();
            }

            return con;
        }

        public static int MoreQuestion2(IntNode lst, int num)
        {
            int count = 0;

            while (lst != null)
            {
                if (lst.GetValue() == num)
                {
                    if (lst.GetNext() == null)
                    {
                        count++;
                    }
                    else if (lst.GetNext().GetValue() != num)
                    {
                        count++;
                    }
                }
                lst = lst.GetNext();
            }

            return count;
        }

        public static char MoreQuestion4(IntNode lst)
        {
            char ch = 's';
            int eCount = 0, zCount = 0;

            while (lst != null)
            {
                if (lst.GetValue() % 2 == 0)
                {
                    zCount++;
                }
                else
                {
                    eCount++;
                }
                lst = lst.GetNext();
            }

            if (zCount > eCount)
            {
                ch = 'z';
            }
            else if (eCount > zCount)
            {
                ch = 'e';
            }

            return ch;
        }

        public static IntNode MoreQuestion5(IntNode lst, int num)
        {
            IntNode temp;
            IntNode pos = lst;
            
            while (pos != null)
            {
                temp = pos.GetNext();
                if (temp != null && temp.GetValue() == num)
                {
                    pos.SetNext(temp.GetNext());
                    temp = null;
                }
                pos = pos.GetNext();
            }

            return lst;
        }
    }
}
