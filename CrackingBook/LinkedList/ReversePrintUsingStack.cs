using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    public class ReversePrintUsingStack
    {
        public static void usingStack(SinglyLinkedListNode<int> node)
        {
            var stck = new Utils.Stack<int>();
            while (node != null) {
                stck.Push(node.Data);
                node = node.Next;
            }

            while (!stck.IsEmpty()) {
                Console.WriteLine(stck.Pop());
            }
        }

        //static void Main(string[] args)
        //{
        //    var node = new SinglyLinkedListNode<int>(4);
        //    var list = new MyLinkedList<int>(new SinglyLinkedListNode<int>(1));
        //    list.head.Next = new SinglyLinkedListNode<int>(2);
        //    list.head.Next.Next = new SinglyLinkedListNode<int>(3);
        //    list.head.Next.Next.Next = node;
        //    list.head.Next.Next.Next.Next = new SinglyLinkedListNode<int>(5);
        //    list.head.Next.Next.Next.Next.Next = new SinglyLinkedListNode<int>(6);
        //    list.head.Next.Next.Next.Next.Next.Next = new SinglyLinkedListNode<int>(7);
        //    list.head.Next.Next.Next.Next.Next.Next.Next = new SinglyLinkedListNode<int>(8);
        //    list.head.Next.Next.Next.Next.Next.Next.Next.Next = new SinglyLinkedListNode<int>(9);
        //    //list.head.Next.Next.Next.Next.Next.Next.Next.Next.Next = node;

        //    usingStack(list.head);
        //}
    }
}
