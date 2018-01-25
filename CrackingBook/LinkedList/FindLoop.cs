using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    public class FindLoop
    {
        public static void findLinkLoop(SinglyLinkedListNode<int> node)
        {
            bool isLoop = false;
            if (node == null || node.Next == null)
            {
                Console.WriteLine("False");
            }
            var slow = node;
            var fast = node.Next.Next;

            while (fast != null && fast.Next != null)
            {
                if (slow.Data == fast.Data) {
                    isLoop = true;
                    break;
                }
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            Console.WriteLine(isLoop);

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

        //    findLinkLoop(list.head);
        //}
    }
}
