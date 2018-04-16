using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    public class CheckBst
    {

        public static bool checkBST(TreeNode<int> root)
        {
            return Check(root, null, null);
        }

        private  static bool Check(TreeNode<int> n, int? min, int? max)
        {
            if (n == null)
            {
                return true;
            }
            else if (( min != null && n.data <= min) || (max != null && n.data >= max))
            {
                return false;
            }
            else
            {
                return Check(n.left, min, n.data) && Check(n.right, n.data, max);
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
		//    root.right.left = new TreeNode<int>(9);
  //          Console.Write(checkBST(root));
		//}
	}
}
