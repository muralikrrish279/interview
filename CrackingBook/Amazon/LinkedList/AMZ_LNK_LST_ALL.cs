using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook.Amazon.LinkedList
{

    public class AMZ_LNK_LST_ALL
    {
        //http://www.geeksforgeeks.org/reverse-a-linked-list/
        public SinglyLinkedListNode<int> Reverse(SinglyLinkedListNode<int> node)
        {
            SinglyLinkedListNode<int> next = null;
            SinglyLinkedListNode<int> current = node;
            SinglyLinkedListNode<int> prev = null;

            while (current != null) {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            node = prev;
            return node;
        }

        //http://www.geeksforgeeks.org/write-a-c-function-to-print-the-middle-of-the-linked-list/
        public void FindMiddle(SinglyLinkedListNode<int> node)
        {
            SinglyLinkedListNode<int> slow = node;
            SinglyLinkedListNode<int> fast = node;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            Console.WriteLine( slow.Data);
        }
    }
}

