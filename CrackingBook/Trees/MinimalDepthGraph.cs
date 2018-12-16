using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook.Trees
{
    public class MinimalDepthGraph
    {

        public class Node<T>
        {
            public Node<T>[] children;
            public T data;
            public bool Visited;
            public int depth;
        }

        public int MinimalDepth(Node<int>[] nodes)
        {
            if (nodes == null)
            {
                return 0;
            }
            var minDepth = int.MaxValue;
            foreach (var item in nodes)
            {
                var depth = this.MinimalDepthHelper(item);
                if (depth < minDepth)
                {
                    minDepth = depth;
                }
            }
            return minDepth;
        }

        public int MinimalDepthHelper(Node<int> node)
        {
            if (node == null)
            {
                return 0;
            }

            var que = new Utils.Queue<Node<int>>();
            que.EnQueue(node);

            while (!que.IsEmpty())
            {
                var temp = que.DeQueue();
                if (temp.children != null && temp.children.Length > 0) {
                    foreach (var item in temp.children)
                    {
                        return this.MinimalDepthHelper(item) + 1;
                    }
                }
            }
            return 0;

        }
    }
}
