using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    //Expedia phone round question
    public class RootToLeafSum
    {
        

        public static void FindSum(TreeNode<int> node1, int currentSum)
        {
			if(node1 == null){
				return;
			}

			currentSum += node1.data;
			if(node1.left == null && node1.right == null){
				Console.WriteLine(currentSum);
			}

			FindSum(node1.left, currentSum);
			FindSum(node1.right, currentSum);
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

        //    FindSum(root, 0);
        //}
    }
}
