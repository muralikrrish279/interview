using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    //Expedia phone round question
    public class BSTFromPreOrder
    {
        public static void FormBST(int[] arr)
        {

            var stck = new Stack<TreeNode<int>>();
            var root = new TreeNode<int>(arr[0]);
            stck.Push(root);

            for (int i = 1; i < arr.Length; i++)
            {
                TreeNode<int> temp = null;
                while (!stck.IsEmpty() && arr[i] > stck.Peek().data)
                {
                    temp = stck.Pop();
                }

                if (temp != null)
                {
                    temp.right = new TreeNode<int>(arr[i]);
                    stck.Push(temp.right);
                }
                else
                {
                    temp = stck.Peek();
                    temp.left = new TreeNode<int>(arr[i]);
                    stck.Push(temp.left);
                }
            }


            Traversal.BFSTraverse(root);

        }

        //static void Main(string[] args)
        //{
        //    //var arr = new int[] { 4, 2, 1, 3, 7, 6, 9 };
        //    //FormBST(arr);
        //}
    }
}
