using System;
using System.Collections.Generic;
using System.Text;

namespace AdirEf11th
{
    public class IntNode
    {
        private int value;
        private IntNode next;

        public IntNode(int value)
        {
            this.value = value;
            this.next = null;
        }

        public IntNode(int value, IntNode next)
        {
            this.value = value;
            this.next = next;
        }

        public int GetValue()
        {
            return this.value;
        }

        public IntNode GetNext()
        {
            return this.next;
        }

        public void SetNext(IntNode next)
        {
            this.next = next;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
