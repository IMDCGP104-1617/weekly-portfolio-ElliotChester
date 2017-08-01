using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lists
{
    class List<T>
    {
        public class Node
        {
            public T Data;
            public Node Next;
        }

        private Node head;
        private int count = 0;

        public T Head { get { return head.Data; } }

        public List()
        {
            head = null;
        }

        public void InsertBeginning(T data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
            count++;
        }

        public T RemoveBeginning() {
            T ret = default(T);
            if(head != null)
            {
                ret = head.Data;
                if(head.Next == null)
                {
                    head = null;
                }
                else
                {
                    head = head.Next;
                }
            }
            count--;
            return ret;
        }

        public void InsertEnd(T data)
        {
            if (head == null)
            {
                InsertBeginning(data);
            }
            else
            {
                Node current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                Node newNode = new Node();
                newNode.Data = data;
                newNode.Next = null;
                current.Next = newNode;
            }
        }

        public T RemoveAfter(int count)
        {
            T ret = default(T);

            Node current = head;
            int counter = 0;

            while (current != null)
            {
                if(current.Next != null)
                {
                    ret = current.Next.Data;
                    current.Next = current.Next.Next;
                    counter--;
                }

                break;
            }

            current = current.Next;

            return ret;

        }
    }
}
