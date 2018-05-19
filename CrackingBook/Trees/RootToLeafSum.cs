using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    //Expedia phone round question
    public class IsSubTree
    {
        public static bool CheckSubTree(TreeNode<int> node1, TreeNode<int> node2)
        {
            if (node1 == null)
            {
                return false;
            }
            if (node1.data == node2.data && MAtchTree(node1, node2))
            {
                return true;
            }
            return CheckSubTree(node1.left, node2) || CheckSubTree(node1.right, node2);
        }

        public static bool MAtchTree(TreeNode<int> node1, TreeNode<int> node2)
        {
            if (node1 == null && node2 == null) {
                return true;
            }
            if (node1 == null || node2 == null)
            {
                return false;
            }
            if (node1.data != node2.data)
            {
                return false;
            }
            return MAtchTree(node1.left, node2.left) && MAtchTree(node1.right, node2.right);
        }

        //static void Main(string[] args)
        //{

        //    var root = new TreeNode<int>(4);
        //    root.left = new TreeNode<int>(2);
        //    root.right = new TreeNode<int>(7);
        //    root.left.left = new TreeNode<int>(1);
        //    root.left.right = new TreeNode<int>(3);
        //    root.right.left = new TreeNode<int>(6);
        //    root.right.right = new TreeNode<int>(9);

       
        //    var node1 = new TreeNode<int>(7);
        //    node1.left = new TreeNode<int>(6);
        //    node1.right = new TreeNode<int>(10);
        //    Console.WriteLine(CheckSubTree(root, node1));
        //}
    }
}
