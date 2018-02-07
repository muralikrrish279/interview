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
        public static SinglyLinkedListNode<int> MergeListLink(SinglyLinkedListNode<int> node1, SinglyLinkedListNode<int> node2)
        {
            SinglyLinkedListNode<int> result = null;
            if (node1 == null && node2 == null)
            {
                return null;
            }
            if (node1 == null) {
                return node2;
            }
            if (node2 == null)
            {
                return node1;
            }

            if (node1.Data < node2.Data)
            {
                result = node1;
                result.Next = MergeListLink(node1.Next, node2);
            }
            else {
                result = node2;
                result.Next = MergeListLink(node1, node2.Next);
            }
            return result;
        }

        //static void Main(string[] args)
        //{
        //    var list = new MyLinkedList<int>(new SinglyLinkedListNode<int>(1));
        //    list.head.Next = new SinglyLinkedListNode<int>(2);
        //    list.head.Next.Next = new SinglyLinkedListNode<int>(3);
        //    list.head.Next.Next.Next = new SinglyLinkedListNode<int>(7);

        //    var list2 = new MyLinkedList<int>(new SinglyLinkedListNode<int>(4));
        //    list2.head.Next = new SinglyLinkedListNode<int>(5);
        //    list2.head.Next.Next = new SinglyLinkedListNode<int>(6);
        //    list2.head.Next.Next.Next = new SinglyLinkedListNode<int>(8);

        //    var output = MergeListLink(list.head, list2.head);
        //    output.Print();
        //}
    }
}
