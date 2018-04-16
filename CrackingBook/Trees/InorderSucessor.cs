using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    public class Successor
    {

        public static void Succ(TreeNode<int> node)
        {

            //case 1
            if(node != null && node.right != null){
                Console.WriteLine(minNode(node.right).data);
                return;
            }else{
                var p = node.parent;
                while(p != null && node == p.right){
                    node = p;
                    p = p.parent;
                }
                Console.WriteLine(p.data);
            }
        }

        private  static TreeNode<int> minNode(TreeNode<int> node)
        {
            while (node.left != null)
            {
                node = node.left;
            }
            return node;
        }

		//static void Main(string[] args)
		//{
  //          // // case 1
  //    //      var search = new TreeNode<int>(10);
		//    //var root = new TreeNode<int>(15);
		//    //root.left = search;
		//    //root.right = new TreeNode<int>(20);
		//    //root.left.left = new TreeNode<int>(8);
		//    //root.left.right = new TreeNode<int>(12);
		//    //root.left.right.left = new TreeNode<int>(11);
  //    //      root.left.left.left = new TreeNode<int>(6);
		//    //root.right.right = new TreeNode<int>(25);
		//    //root.right.left = new TreeNode<int>(17);
  //          //Succ(search);

  //          // //case 2;
		//	var search = new TreeNode<int>(12);
		//	var root = new TreeNode<int>(15);
		//	root.left = new TreeNode<int>(10);
		//	root.right = new TreeNode<int>(20);
  //          root.left.parent = root.right.parent = root;

		//	root.left.left = new TreeNode<int>(8);
		//	root.left.right = search;
  //          root.left.left.parent = root.left.right.parent = root.left;

		//	root.left.right.left = new TreeNode<int>(11);
  //          root.left.right.left.parent = root.left.right;
		//	root.left.left.left = new TreeNode<int>(6);
  //          root.left.left.left.parent = root.left.left;
		//	root.right.right = new TreeNode<int>(25);
		//	root.right.left = new TreeNode<int>(17);
  //          root.right.right.parent = root.right.left.parent = root.right;
		//	Succ(search);
		//}

		public class TreeNode<T>
		{
			public TreeNode<T> left;
			public TreeNode<T> right;
            public TreeNode<T> parent;
			public T data;
			public bool Visited;
			public TreeNode(T input)
			{
				data = input;
				left = right = parent= null;
			}


		}
	}
}
