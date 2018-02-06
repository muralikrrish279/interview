using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    //Expedia phone round question
    public class LCAInBST
    {
        public static void FindLCA(TreeNode<int> root, int data1 ,int data2) {
            if (root.data > data1 && root.data > data2)
            {
                FindLCA(root.left, data1, data2);
            }
            else if (root.data < data1 && root.data < data2)
            {
                FindLCA(root.right, data1, data2);
            }
            else {
                Console.WriteLine(root.data);
            }
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
        //    FindLCA(root,3,9); 
        //}
    }
}
