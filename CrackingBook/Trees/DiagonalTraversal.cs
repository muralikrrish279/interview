using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    //Expedia phone round question
    public class DiagonalTraversal
    {
        public static void TraverseDiag(TreeNode<int> root)
        {
            if (root == null) {
                return;
            }
            var queu = new Queue<TreeNode<int>>();
            var temp = root;
            while (temp != null) {
                queu.EnQueue(temp);
                temp = temp.right;
            }

            while (!queu.IsEmpty()) {
                var node = queu.DeQueue();
                if (node.left != null) {
                    var t1 = node.left;
                    while (t1 != null)
                    {
                        queu.EnQueue(t1);
                        t1 = t1.right;
                    }
                }
                if (!node.Visited) {
                    node.Visited = true;
                    Console.WriteLine(node.data);
                }
            }

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
        //    root.right.left = new TreeNode<int>(13);
        //    TraverseDiag(root);
        //}
    }
}
