using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Utils
{
    public class Stack<T>
    {
        SinglyLinkedListNode<T> top = null;

        public void Push(T input)
        {
            var t = new SinglyLinkedListNode<T>(input);
            t.Next = top;
            top = t;
        }

        public T Pop()
        {
            if (!IsEmpty()) {
                T output = top.Data;
                top = top.Next;
                return output;
            }
            return default(T);
        }

        public T Peek()
        {
            if (!IsEmpty()) {
                return top.Data;
            }
            return default(T);
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Print()
        {
            var temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
