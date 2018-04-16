using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;
using System.Collections.Generic;

namespace CrackingBook
{
    
    public class ListOfDepths
    {
        public static void FindDepths(TreeNode<int> node,Dictionary<int,List<int>> path,int level)
        {
            if (node == null) {
                return;
            }

            if(path.ContainsKey(level)){
                path[level].Add(node.data);
            }else{
                path.Add(level,new List<int>(){node.data});
            }

            FindDepths(node.left,path,level+1);
			FindDepths(node.right, path, level + 1);

		}

        public static void FindDepth(TreeNode<int> node, Dictionary<int, List<int>> path, int level)
        {
            FindDepths(node,path,level);
            foreach (var item in path)
            {
                foreach (var x in item.Value)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            Console.Read();
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
        //    FindDepth(root,new Dictionary<int, List<int>>(),0);
        //}
    }
}
