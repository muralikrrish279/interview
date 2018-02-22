using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    public class FindIntersection
    {

        public static int Count(SinglyLinkedListNode<int> node1) {
            int count = 0;
            while (node1 != null) {
                count++;
                node1 = node1.Next;
            }
            return count;
        }
        public static void findInterSection(SinglyLinkedListNode<int> node1, SinglyLinkedListNode<int> node2)
        {
            int n1 = Count(node1);
            int n2 = Count(node2);
            if (n1 > n2)
            {
                var d = n1 - n2;
                while (d > 0)
                {
                    node1 = node1.Next;
                    d--;
                }
            }
            else {
                var d = n2 - n1;
                while (d > 0)
                {
                    node2 = node2.Next;
                    d--;
                }
            }

            while (node1 != null && node2 != null)
            {
                if (node1 == node2) {
                    Console.WriteLine("Intersction Found at : " + node1.Data);
                    return;
                }
                node1 = node1.Next;
                node2 = node2.Next;
            }
            Console.WriteLine("No Intersection");
        }

        //static void Main(string[] args)
        //{
            
        //    var list1 = new MyLinkedList<int>(new SinglyLinkedListNode<int>(1));
        //    list1.head.Next = new SinglyLinkedListNode<int>(2);
        //    list1.head.Next.Next = new SinglyLinkedListNode<int>(3);
        //    list1.head.Next.Next.Next = new SinglyLinkedListNode<int>(4);
        //    list1.head.Next.Next.Next.Next = new SinglyLinkedListNode<int>(5);
        //    list1.head.Next.Next.Next.Next.Next = new SinglyLinkedListNode<int>(6);
        //    var node7 = new SinglyLinkedListNode<int>(7);
        //    var node8 = new SinglyLinkedListNode<int>(8);
        //    var node9 = new SinglyLinkedListNode<int>(9);
        //    list1.head.Next.Next.Next.Next.Next.Next = node7;
        //    list1.head.Next.Next.Next.Next.Next.Next.Next = node8;
        //    list1.head.Next.Next.Next.Next.Next.Next.Next.Next = node9;


        //    var list2 = new MyLinkedList<int>(new SinglyLinkedListNode<int>(5));
        //    list2.head.Next = new SinglyLinkedListNode<int>(6);
        //    //list2.head.Next.Next = node7;
        //    //list2.head.Next.Next.Next = node8;
        //    //list2.head.Next.Next.Next.Next = node9;
        //    list2.head.Next.Next = new SinglyLinkedListNode<int>(7);
        //    list2.head.Next.Next.Next = new SinglyLinkedListNode<int>(8);
        //    list2.head.Next.Next.Next.Next = new SinglyLinkedListNode<int>(9);
        //    findInterSection(list1.head,list2.head);
        //}
    }
}
