using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueues
{
    class SortStack
    {
        public static void sort(Stack<int> s)
        {
            Stack<int> temp = new Stack<int>();

            while(s.Count > 0)
            {
                int val = s.Pop();

                while (temp.Count > 0 && temp.Peek() > val)
                    s.Push(temp.Pop());

                temp.Push(val);
            }

            while (temp.Count > 0)
                s.Push(temp.Pop());
        }
    }
}
