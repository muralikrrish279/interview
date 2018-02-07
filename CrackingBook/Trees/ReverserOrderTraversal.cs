using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    //Expedia phone round question
    public class ReverserOrderTraversal
    {
        public static void TraverseReverser(TreeNode<int> root)
        {
            if (root == null)
            {
                return;
            }
            var queu = new Queue<TreeNode<int>>();
            var sck = new Stack<int>();

            queu.EnQueue(root);

            while (!queu.IsEmpty())
            {
                var temp = queu.DeQueue();
                sck.Push(temp.data);

                if (temp.right != null)
                {
                    queu.EnQueue(temp.right);
                }
                if (temp.left != null)
                {
                    queu.EnQueue(temp.left);
                }

                
            }

            while (!sck.IsEmpty())
            {
                Console.WriteLine(sck.Pop());
            }
        }

        //static void Main(string[] args)
        //{

        //    var root = new TreeNode<int>(1);
        //    root.left = new TreeNode<int>(2);
        //    root.right = new TreeNode<int>(3);
        //    root.left.left = new TreeNode<int>(4);
        //    root.left.right = new TreeNode<int>(5);
        //    root.right.left = new TreeNode<int>(6);
        //    root.right.right = new TreeNode<int>(7);
        //    Traversal.BFSTraverse(root);
        //    Console.WriteLine("");
        //    TraverseReverser(root);
        //}
    }
}
