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

        public void Print()
        {
            var temp = this;
            while (temp != null)
            {
                Console.Write(temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
    public class MyLinkedList<T>
    {
        public SinglyLinkedListNode<T> head;
        public MyLinkedList(SinglyLinkedListNode<T> value)
        {
            this.head = value;
        }

        public MyLinkedList(T[] arr)
        {
            SinglyLinkedListNode<T> root = null;
            SinglyLinkedListNode<T> temp = null;
            foreach (var item in arr)
            {
                if (temp == null)
                {
                    root = new SinglyLinkedListNode<T>(item);
                    temp = root;
                }
                else
                {
                    temp.Next = new SinglyLinkedListNode<T>(item);
                }
                temp = temp.Next;
            }
            this.head = temp;
        }

        public void Print(SinglyLinkedListNode<T> node)
        {
            while (node != null)
            {
                Console.Write(node.Data);
                node = node.Next;
            }
            Console.WriteLine();
        }

    }
}
