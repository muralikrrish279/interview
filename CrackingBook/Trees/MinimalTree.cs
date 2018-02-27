using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrackingBook.Utils;
using System.Threading.Tasks;

namespace CrackingBook.Trees
{
    class MinimalTree
    {

        public TreeNode<int> MinimalTree1(int[] arr)
        {
            if (arr.Length > 0)
            {
                return buildTree(arr, 0, arr.Length - 1);
            }
            return null;
        }


        private TreeNode<int> buildTree(int[] arr, int start, int end)
        {
            if (end < start)
            {
                return null;
            }

            var mid = (start + end) / 2;
            var root = new TreeNode<int>(arr[mid]);
            root.left = buildTree(arr, start, mid - 1);
            root.right = buildTree(arr, mid + 1, end);
            return root;
        }
    }
}
