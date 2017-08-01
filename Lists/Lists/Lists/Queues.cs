﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Queue<T>
    {
        private List<T> queue;

        private int count = 0;

        public int Count { get { return count; } }

        public Queue() //stack class
        {
            queue = new List<T>(); //instialize our stack
        }

        ~Queue() 
        {
            while (!IsEmpty())
            {
                T output;
                DeQueue(out output); 
            }
        }

        public void EnQueue(T Data)
        {
            count++;
            queue.InsertEnd(Data);
            
        }

        public bool DeQueue(out T output)
        {
            output = default(T);

            if (IsEmpty())
            {
                return false;
            }

            output = queue.RemoveBeginning();
            count--;
            return true;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

    }
}
