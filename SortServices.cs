using System;
using System.Collections.Generic;
using System.Text;

namespace AdirEf11th
{
    public class SortServices
    {
        public static IComparable[] SortArr(IComparable[] arr)
        {
            IComparable temp;
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; i++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        public static Node<IComparable> SortLinkedList(Node<IComparable> lst)
        {
            int count = 0;
            Node<IComparable> pos = lst;
            IComparable[] arr;
            Node<IComparable> newLst = null;

            while (pos != null)
            {
                count++;
                pos = pos.GetNext();
            }
            arr = new IComparable[count];

            pos = lst;
            for (int i = count - 1; i >= 0; i--)
            {
                arr[i] = pos.GetValue();
                pos = pos.GetNext();
            }

            arr = SortArr(arr);

            for (int i = count - 1; i >= 0; i--)
            {
                newLst = new Node<IComparable>(arr[i], newLst);
            }

            return newLst;
        }
    }
}
