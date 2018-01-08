using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Utils
{
    public class SinglyLinkedListNode<T>
    {
        public T Data;
        public SinglyLinkedListNode<T> Next;

        public SinglyLinkedListNode(T value)
        {
            this.Data = value;
            this.Next = null;
        }
    }
    public class MyLinkedList<T>
    {
        public SinglyLinkedListNode<T> head;
        public MyLinkedList(SinglyLinkedListNode<T> value)
        {
            this.head = value;
        }

        public void Print(SinglyLinkedListNode<T> node) {
            while (node != null) {
                Console.Write(node.Data);
                node = node.Next;
            }
            Console.WriteLine();
        }

    }
}
