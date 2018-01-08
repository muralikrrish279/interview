using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.LinkedList
{
    class DeleteDuplicates
    {

        public void DeleteDups(LinkedListNode<int> input) //abc
        {
            Dictionary<int, bool> dic = new Dictionary<int, bool>();
            LinkedListNode<int> buffer = null;
            while (input != null) //a -> b -> a -> c
            {
                if (dic.ContainsKey(input.Value))
                {
                    //buffer.Next = input.Next;
                }
                else
                {
                    dic.Add(input.Value, true);
                    buffer = input;
                }
                input = input.Next;
            }
        }

        void PrintLinkedList(LinkedListNode<int> input)
        {
            while (input != null)
            {
                Console.Write(input.Value);
                input = input.Next;
            }
        }
    }
}
