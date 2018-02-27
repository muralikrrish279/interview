using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook.Trees
{
    public class BSTInsert
    {
        
        //Binary Search Tree Insert
        public TreeNode<int> Insert(TreeNode<int> root, int key)
        {
            if (root == null)
            {
                root = new TreeNode<int>(key);
                return root;
            }

            if (key < root.data)
                root.left = Insert(root.left, key);
            else if (key > root.data)
                root.right = Insert(root.right, key);

            return root;
        }
    }
}
