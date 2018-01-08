using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Trees
{
    public class CheckBst
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
        }

        public bool checkBST(CheckBst.Node root)
        {
            return Check(root, 0, 10000);
        }

        private bool Check(Node n, int min, int max)
        {
            if (n == null)
            {
                return true;
            }
            else if (n.data <= min || n.data >= max)
            {
                return false;
            }
            else
            {
                return Check(n.left, min, n.data) && Check(n.right, n.data, max);
            }
        }
    }
}
