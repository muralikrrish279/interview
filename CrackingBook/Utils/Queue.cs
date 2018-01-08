using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Utils
{
    public class Queue<T>
    {

        SinglyLinkedListNode<T> First;
        SinglyLinkedListNode<T> Last;
        ///
        public bool IsEmpty()
        {
            return First == null;
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                return First.Data;
            }
            return default(T);
        }

        public void EnQueue(T input)
        {
            var t = new SinglyLinkedListNode<T>(input);
            if (Last != null)
            {
                Last.Next = t;
            }
            Last = t;
            if (First == null)
            {
                First = Last;
            }

        }

        public T DeQueue()
        {
            if (First != null)
            {
                var output = First.Data;
                First = First.Next;
                if (First == null)
                {
                    Last = null;
                }
                return output;
            }
            return default(T);
        }

        public void Print()
        {
            var temp = First;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }


    }
}
