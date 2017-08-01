using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Stack<T>
    {
        private List<T> stack;
        private int count;

        public int Count { get { return count; } }

        public Stack()
        {
            stack = new List<T>();
        }

        ~Stack() //Deconstructor
        {
            while (!IsEmpty())
            {
                T output;
                Pop(out output);
            }
        }

        public void Push(T data)
        {
            count++;
            stack.InsertBeginning(data);
        }

        public bool Pop(out T output)
        {
            output = default(T);
            if (IsEmpty())
            {
                return false;
            }
            output = stack.RemoveBeginning();
            count--;
            return true;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Peek()
        {
            return stack.Head;
        }

    }
}
