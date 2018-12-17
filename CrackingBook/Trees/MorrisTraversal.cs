using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook.Trees
{
    class MorrisTraversal
    {

        static void MorrisTraversal1(TreeNode<int> root)
        {
            TreeNode<int> current, pre;

            if (root == null)
                return;

            current = root;
            while (current != null)
            {
                if (current.left == null)
                {
                    Console.WriteLine(current.data + " ");
                    current = current.right;
                }
                else
                {
                    /* Find the inorder predecessor of current */
                    pre = current.left;
                    while (pre.right != null && pre.right != current)
                        pre = pre.right;

                    /* Make current as right child of its inorder predecessor */
                    if (pre.right == null)
                    {
                        pre.right = current;
                        current = current.left;
                    }

                    /* Revert the changes made in if part to restore the  
                        original tree i.e., fix the right child of predecssor*/
                    else
                    {
                        pre.right = null;
                        Console.WriteLine(current.data + " ");
                        current = current.right;
                    } /* End of if condition pre->right == NULL */

                } /* End of if condition current->left == NULL*/

            } /* End of while */
        }

        //public static void Main()
        //{
        //    /* Constructed binary tree is 
        //           1 
        //         /   \ 
        //        2      3 
        //      /  \ 
        //    4     5 
        //    */
        //    BinaryTree<int> tree = new BinaryTree<int>();
        //    tree.Root = new TreeNode<int>(1);
        //    tree.Root.left = new TreeNode<int>(2);
        //    tree.Root.right = new TreeNode<int>(3);
        //    tree.Root.left.left = new TreeNode<int>(4);
        //    tree.Root.left.right = new TreeNode<int>(5);

        //    MorrisTraversal1(tree.Root);
        //}
    }
}
