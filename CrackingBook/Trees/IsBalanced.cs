using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook.Microsoft
{
    public class IsBalanced
    {

        //http://www.geeksforgeeks.org/how-to-determine-if-a-binary-tree-is-balanced/
        public bool IsBalanced1(TreeNode<int> Root)
        {
            //Binary tree is balanced is left and right trees height differencr is not more than 1
            //1
            //2 3
            if (Root == null)
            {
                return true;
            }

            int lh = 0;
            int rh = 0;

            lh = Height(Root.left);
            rh = Height(Root.right);

            if (Math.Abs(rh - lh) <= 1 && IsBalanced(Root.left) && IsBalanced(Root.right))
            {
                return true;
            }

            return false;
        }

        private int Height(TreeNode<int> node)
        {
            if (node == null)
            {
                return 0;
            }
            return 1 + Math.Max(Height(node.left), Height(node.right));
        }
      


    }
}