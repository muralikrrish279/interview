using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    public class MergeList
    {
        public static void MergeListLink(SinglyLinkedListNode<int> node1, SinglyLinkedListNode<int> node2)
        {
            SinglyLinkedListNode<int> p = node1;
            SinglyLinkedListNode<int> q = node2;
            SinglyLinkedListNode<int> n1Next = null;
            SinglyLinkedListNode<int> n2Next = null;
            if (p == null && q == null)
            {
                return;
            }

            while (p != null && q != null)
            {
                n1Next = p.Next;
                n2Next = q.Next;

                p.Next = q;
                q.Next = n1Next;

                p = n1Next;
                q = n2Next;
            }

            q.Print();
        }

        //static void Main(string[] args)
        //{
        //    var list = new MyLinkedList<int>(new SinglyLinkedListNode<int>(1));
        //    list.head.Next = new SinglyLinkedListNode<int>(2);
        //    list.head.Next.Next = new SinglyLinkedListNode<int>(3);
        //    list.head.Next.Next.Next = new SinglyLinkedListNode<int>(4);

        //    var list2 = new MyLinkedList<int>(new SinglyLinkedListNode<int>(5));
        //    list2.head.Next = new SinglyLinkedListNode<int>(6);
        //    list2.head.Next.Next = new SinglyLinkedListNode<int>(7);
        //    list2.head.Next.Next.Next = new SinglyLinkedListNode<int>(8);

        //    MergeListLink(list.head, list2.head);
        //}
    }
}
