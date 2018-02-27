using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook.Trees
{
    public class MinimalDepth
    {


        public class item
        {
            public item(TreeNode<int> node, int depth)
            {
                this.node = node;
                this.depth = depth;
            }
            public TreeNode<int> node;
            public int depth;
        }
        public int MinimalDepth1(TreeNode<int> node) //Level Order Traversal
        {
            if (node == null)
            {
                return 0;
            }

            var que = new Utils.Queue<item>();
            que.EnQueue(new item(node, 1));

            while (!que.IsEmpty())
            {
                var temp = que.DeQueue();
                if (temp.node.left == null && temp.node.right == null)
                {
                    return temp.depth;
                }

                if (temp.node.left != null)
                {
                    var newItem = new item(temp.node.left, temp.depth + 1);
                    que.EnQueue(newItem);
                }

                if (temp.node.right != null)
                {
                    var newItem = new item(temp.node.right, temp.depth + 1);
                    que.EnQueue(newItem);
                }
            }
            return 0;

        }
    }
}
