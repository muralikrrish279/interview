using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Utils
{
    public class BinaryTree<T>
    {
        public TreeNode<T> Root;
    }

    public enum Traversals
    {
       PreOrder, //root left right
       InOrder, //left root right
       PostOrder //left right root
    }

    public class TreeNode<T>
    {
        public TreeNode<T> left;
        public TreeNode<T> right;
        public T data;
        public bool Visited;
        public TreeNode(T input) {
            data = input;
            left = right = null;
        }
        
    }
    
}
