using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueues
{
    class QueueUsingStacks
    {
        Stack<int> s1;
        Stack<int> s2;

        public QueueUsingStacks()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        public void queue(int val)
        {
            s1.Push(val);
        }

        public int dequeue()
        {
            if (s2.Count == 0)
                fills2();
            return s2.Pop();
        }

        public int peek()
        {
            if (s2.Count == 0)
                fills2();
            return s2.Peek();
        }

        public int size()
        {
            return s1.Count + s2.Count;
        }

        private void fills2()
        {
            while (s1.Count > 0)
                s2.Push(s1.Pop());
        }
    }
}
