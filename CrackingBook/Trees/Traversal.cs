using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    //Expedia phone round question
    public class Traversal
    {

		//static void Main(string[] args)
   //     {

   //         var root = new TreeNode<int>(4);
   //         root.left = new TreeNode<int>(2);
   //         root.right = new TreeNode<int>(7);
   //         root.left.left = new TreeNode<int>(1);
   //         root.left.right = new TreeNode<int>(3);
   //         root.right.left = new TreeNode<int>(6);
   //         root.right.right = new TreeNode<int>(9);

			//DFSTraverse(root, Traversals.PreOrder);
        //}

        public static void DFSTraverse(TreeNode<int> node, Traversals type)
        {
            if (node == null)
            {
                return;
            }
            switch (type)
            {
                case Traversals.PreOrder:
                    Console.WriteLine(node.data);
                    DFSTraverse(node.left, Traversals.PreOrder);
                    DFSTraverse(node.right, Traversals.PreOrder);
					Console.WriteLine(node.data.ToString() + " Done");
                    break;
                case Traversals.InOrder:
                    DFSTraverse(node.left, Traversals.InOrder);
                    Console.WriteLine(node.data);
                    DFSTraverse(node.right, Traversals.InOrder);
                    break;
                case Traversals.PostOrder:
                    DFSTraverse(node.left, Traversals.PostOrder);
                    DFSTraverse(node.right, Traversals.PostOrder);
                    Console.WriteLine(node.data);
                    break;
                default:
                    break;
            }
        }

        public static void BFSTraverse<T>(TreeNode<T> node) //Level Order Traversal
        {
            if (node == null)
            {
                return;
            }
            var queu = new Utils.Queue<TreeNode<T>>();
            queu.EnQueue(node);

            while (!queu.IsEmpty())
            {
                var temp = queu.DeQueue();
                Console.WriteLine(temp.data);
                temp.Visited = true;
                if (temp.left != null)
                {
                    if (!temp.left.Visited)
                    {
                        temp.left.Visited = true;
                        queu.EnQueue(temp.left);
                    }
                }
                if (temp.right != null)
                {
                    if (!temp.right.Visited)
                    {
                        temp.right.Visited = true;
                        queu.EnQueue(temp.right);
                    }
                }

            }

        }
    }
}
