using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueues
{
    class SetOfStacks
    {
        List<Stack<int>> stacks = new List<Stack<int>>();
        int capacity = 3;

        private Stack<int> getLastStack()
        {
            if (stacks.Count == 0) return null;
            return stacks[stacks.Count - 1];
        }

        public void push(int val)
        {
            Stack<int> t = getLastStack();

            if (t == null || t.Count == capacity)
            {
                t = new Stack<int>(capacity);
                t.Push(val);
                stacks.Add(t);
            }
            else
                t.Push(val);
        }

        public int pop()
        {
            Stack<int> t = getLastStack();

            if (t == null)
                throw new Exception();

            int v = t.Pop();
            if (t.Count == 0)
                stacks.Remove(stacks[stacks.Count - 1]);

            return v;
        }

    }
}
