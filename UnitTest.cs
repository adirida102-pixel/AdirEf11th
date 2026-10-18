namespace AdirEf11th
{
    public class UnitTest
    {
        public static void Run()
        {
            //Test1();
            //TestLinkedList();

            //IntNode n1 = new IntNode(99);
            //IntNode n = new IntNode(102, n1);
            //IntNode pos = n;
            //n1 = null;
            //n.GetNext().SetNext(new IntNode(12));
            //n.GetNext().GetNext().SetNext(new IntNode(17));
            //n.GetNext().GetNext().GetNext().SetNext(new IntNode(5));
            //n.GetNext().GetNext().GetNext().GetNext().SetNext(new IntNode(61));

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
            //IntNode newL = MoreQuestion6(n);
            //Console.WriteLine(Print(newL));
            //Console.WriteLine(MoreQuestion8(n));
            //MoreQuestion9(n);
            //Console.WriteLine(Print(MoreQuestion10(3, 5)));
            //Console.WriteLine(Print(MoreQuestion11()));
            //Console.WriteLine(MoreQuestion12(n));
            //Console.WriteLine(Print(MoreQuestion14(n, 3)));
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

        public static IntNode MoreQuestion6(IntNode lst)
        {
            IntNode newLst = new IntNode(lst.GetValue());
            IntNode pos = lst, posNew = newLst;
            int val;
            bool flag = true;
            
            while (pos != null)
            {
                val = pos.GetValue();
                flag = true;
                posNew = newLst;
                while (posNew != null)
                {
                    if (posNew.GetValue() == val)
                    {
                        flag = false;
                    }
                    posNew = posNew.GetNext();
                }
                if (flag)
                {
                    posNew = newLst;
                    while (posNew.GetNext() != null)
                    {
                        posNew = posNew.GetNext();
                    }
                    posNew.SetNext(new IntNode(val));
                }
                pos = pos.GetNext();
            }

            return newLst;
        }

        public static bool MoreQuestion8(IntNode lst)
        {
            bool con = true;

            while (lst.GetNext() != null)
            {
                if (lst.GetValue() >= lst.GetNext().GetValue())
                {
                    con = false;
                }
                lst = lst.GetNext();
            }

            return con;
        }

        public static void MoreQuestion9(IntNode lst)
        {
            while (lst.GetNext() != null)
            {
                if (lst.GetValue() > lst.GetNext().GetValue())
                {
                    Console.WriteLine(lst.GetValue());
                }
                lst = lst.GetNext();
            }
        }

        public static IntNode MoreQuestion10(int beginner, int num)
        {
            IntNode list = new IntNode(beginner);
            IntNode pos = list;

            for (int i = 1; i < num; i++)
            {
                pos.SetNext(new IntNode(beginner + i));
                pos = pos.GetNext();
            }

            return list;
        }

        public static IntNode MoreQuestion11()
        {
            IntNode node = null, list;
            int num = 0;

            Console.WriteLine("Enter num: ");
            num = int.Parse(Console.ReadLine());
            while (num != -999)
            {
                node = new IntNode(num, node);
                Console.WriteLine("Enter num: ");
                num = int.Parse(Console.ReadLine());
            }
            list = node;

            return list;
        }

        public static bool MoreQuestion12(IntNode lst)
        {
            bool con;
            int count = 0, moreCount = 0, lessCount = 0;
            double sum = 0, avg;
            IntNode pos = lst;
            int val;
            
            while (pos != null)
            {
                val = pos.GetValue();
                count++;
                sum += val;
                pos = pos.GetNext();
            }
            avg = sum / count;

            pos = lst;
            while (pos != null)
            {
                val = pos.GetValue();
                if (val > avg)
                {
                    moreCount++;
                }
                else if (val < avg)
                {
                    lessCount++;
                }
                pos = pos.GetNext();
            }
            con = moreCount == lessCount;

            return con;
        }

        public static IntNode MoreQuestion14(IntNode lst, int n)
        {
            int max;
            IntNode pos, temp, next;
            int val;

            for (int i = 0; i < n; i++)
            {
                pos = lst;
                max = pos.GetValue();
                while (pos != null)
                {
                    val = pos.GetValue();
                    if (val > max)
                    {
                        max = val;
                    }
                    pos = pos.GetNext();
                }

                pos = lst;
                while (pos != null)
                {
                    if (pos.GetValue() == max)
                    {
                        if (pos == lst)
                        {
                            lst = lst.GetNext();
                            pos = lst;
                        }
                        else
                        {
                            temp = pos.GetNext();
                            pos.SetNext(temp.GetNext());
                        }
                    }
                    else if (pos.GetNext() != null)
                    {
                        if (pos.GetNext().GetValue() == max && pos.GetNext().GetNext() == null)
                        {
                            pos.SetNext(null);
                        }
                    }
                    pos = pos.GetNext();
                }
            }

            return lst;
        }
    }
}