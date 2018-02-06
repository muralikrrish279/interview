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

        public static void BFSTraverse(TreeNode<int> node) //Level Order Traversal
        {
            if (node == null)
            {
                return;
            }
            var queu = new Utils.Queue<TreeNode<int>>();
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
