using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook.LinkedList
{
    class MustKnow
    {

        //http://www.geeksforgeeks.org/reverse-a-linked-list/
        public SinglyLinkedListNode<int> Reverse(SinglyLinkedListNode<int> node)
        {
            SinglyLinkedListNode<int> next = null;
            SinglyLinkedListNode<int> current = node;
            SinglyLinkedListNode<int> prev = null;

            while (current != null)
            {
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
            Console.WriteLine(slow.Data);
        }

        void PrintLinkedList(LinkedListNode<int> input)
        {
            while (input != null)
            {
                Console.Write(input.Value);
                input = input.Next;
            }
        }

        public SinglyLinkedListNode<int> DeleteNode(SinglyLinkedListNode<int> node, int data)
        {
            var temp = node;
            if (node.Data == data)
            {
                temp = node.Next;
                return temp;
            }
            while (temp != null && temp.Next != null)
            {
                if (temp.Next.Data == data)
                {
                    temp.Next = temp.Next.Next;
                }
                temp = temp.Next;
            }
            return node;
        }

        public SinglyLinkedListNode<int> RemoveDuplicates(SinglyLinkedListNode<int> node)
        {
            SinglyLinkedListNode<int> dummy = node;
            var sets = new HashSet<int>();
            while (node != null)
            {
                if (sets.Contains(node.Data))
                {
                    dummy.Next = node.Next;
                }
                else
                {
                    sets.Add(node.Data);
                    dummy = node;
                }
                node = node.Next;
            }
            return node;
        }


        public SinglyLinkedListNode<int> FindKThElementToLast(SinglyLinkedListNode<int> node, int k)
        {
            SinglyLinkedListNode<int> slow = node;
            SinglyLinkedListNode<int> fast = node;
            for (int i = 0; i < k; i++)
            {
                fast = fast.Next;
            }
            while (fast != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }
            return slow;
        }

        public bool IsPalinDrome(SinglyLinkedListNode<string> node)
        {
            SinglyLinkedListNode<string> slow = node;
            SinglyLinkedListNode<string> fast = node;
            var buffer = new Utils.Stack<string>();
            while (fast != null && fast.Next != null)
            {
                buffer.Push(slow.Data);
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            if (fast != null && fast.Next != null)
            {
                slow = slow.Next;
            }

            while (slow != null)
            {
                if (buffer.Peek() == slow.Data)
                {
                    buffer.Pop();
                }
                slow = slow.Next;
            }
            return buffer.IsEmpty();
        }
    }
}
