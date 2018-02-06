using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook.Microsoft
{
    public class MS_Tree
    {
        public void BuildOrgTree(string[] employeeTable)
        { // Each row has data like -1,CEO,John : 1,John,VP : 1,smith,VP
            foreach (var item in employeeTable)
            {

            }
        }

        //http://www.geeksforgeeks.org/how-to-determine-if-a-binary-tree-is-balanced/
        public bool IsBalanced(TreeNode<int> Root)
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
        
        //Invert a binary tree
        public TreeNode<int> InvertBinaryTree(TreeNode<int> node) //Level Order Traversal
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

        public TreeNode<int> MinimalTree(int[] arr)
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

        public class item {
            public item(TreeNode<int> node, int depth) {
                this.node = node;
                this.depth = depth;
            }
            public TreeNode<int> node;
            public int depth;
        }
        public int MinimalDepth(TreeNode<int> node) //Level Order Traversal
        {
            if (node == null)
            {
                return 0;
            }

            var que = new Utils.Queue<item>();
            que.EnQueue(new item(node, 1));

            while (!que.IsEmpty()) {
                var temp = que.DeQueue();
                if (temp.node.left == null && temp.node.right == null) {
                    return temp.depth;
                }

                if (temp.node.left != null) {
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