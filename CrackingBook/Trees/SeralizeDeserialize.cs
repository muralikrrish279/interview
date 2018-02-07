using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    //Expedia phone round question
    public class SerializeDeserialize
    {
        public static Queue<string> Serialize(TreeNode<int> node, Queue<string> queue)
        {
            if (node == null)
            {
                queue.EnQueue("#");
                return queue;
            }

            queue.EnQueue(node.data.ToString());
            Serialize(node.left, queue);
            Serialize(node.right, queue);

            return queue;
        }

        public static TreeNode<string> DeSerialize(Queue<string> queue)
        {
            TreeNode<string> node = null;
            if (!queue.IsEmpty())
            {
                var temp = queue.DeQueue();
                if (temp == "#")
                {
                    return null;
                }
                node = new TreeNode<string>(temp);
                node.left = DeSerialize(queue);
                node.right = DeSerialize(queue);
            }
            return node;
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
        //    root.right.right.right = new TreeNode<int>(10);
        //    var queue = Serialize(root, new Queue<string>());
        //    var node = DeSerialize(queue);
        //    Traversal.BFSTraverse(node);
        //}
    }
}
