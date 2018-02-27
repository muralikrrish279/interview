using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook.Trees
{
    public class InvertBinaryTree
    {

        //Invert a binary tree
        public TreeNode<int> InvertBinaryTree1(TreeNode<int> node) //Level Order Traversal
        {
            if (node == null)
            {
                return null;
            }
            var queu = new Utils.Queue<TreeNode<int>>();
            queu.EnQueue(node);

            while (!queu.IsEmpty())
            {
                var temp = queu.DeQueue();
                var left = temp.left;
                temp.left = temp.right;
                temp.right = left;
                if (temp.left != null)
                {
                    queu.EnQueue(temp.left);
                }
                if (temp.right != null)
                {
                    queu.EnQueue(temp.right);
                }

            }
            return node;

        }
    }
}
