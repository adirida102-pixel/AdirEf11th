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
    }
}
