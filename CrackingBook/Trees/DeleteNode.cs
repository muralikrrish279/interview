using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    //Expedia phone round question
    public class DeleteNode
    {
        //public static void Delete(TreeNode<int> root, int data)
        //{
        //    //Traversal.BFSTraverse(root);
        //    var n = DeleteHelper(root, data);
        //    Traversal.BFSTraverse(n);

        //}

        public static TreeNode<int> DeleteHelper(TreeNode<int> root, int data)
        {
            if (root == null)
            {
                return root;
            }

            if (root.data < data)
            {
                root.right = DeleteHelper(root.right, data);
            }
            else if (root.data > data)
            {
                root.left = DeleteHelper(root.left, data);
            }
            else
            {
                if (root.left == null)
                {
                    return root.right;
                }
                if (root.right == null)
                {
                    return root.left;
                }

                root.data = minv(root.right);
                root.right = DeleteHelper(root.right, root.data);
            }
            return root;

        }

        public static int minv(TreeNode<int> root)
        {
            var minvalue = root.data;
            while (root.left != null)
            {
                minvalue = root.left.data;
                root = root.left;
            }
            return minvalue;
        }



        //static void Main(string[] args)
        //{

        //    var root = new TreeNode<int>(8);
        //    root.left = new TreeNode<int>(3);
        //    root.right = new TreeNode<int>(10);
        //    root.left.left = new TreeNode<int>(1);
        //    root.left.right = new TreeNode<int>(6);
        //    root.left.right.left = new TreeNode<int>(4);
        //    root.left.right.right = new TreeNode<int>(7);
        //    root.right.right = new TreeNode<int>(14);
        //    root.right.left = new TreeNode<int>(9);
        //    Delete(root, 10);
        //}
    }
}



