using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    //Expedia phone round question
    public class TargetSum
    {
        

        public static int Find1Sum(TreeNode<int> node1, int currentSum,int targetSum,Dictionary<int,int> count)
        {
			if(node1 == null){
				return 0;
			}

			currentSum += node1.data;
			int sum = currentSum - targetSum;
			int totalPaths = 0;
			count.TryGetValue(sum, out totalPaths);

			if(currentSum == targetSum){
				totalPaths++;
			}

			manageHshtable(currentSum, 1, count);
			totalPaths += Find1Sum(node1.left, currentSum, targetSum, count);
			totalPaths += Find1Sum(node1.right, currentSum, targetSum, count);
			manageHshtable(currentSum, -1, count);
			return totalPaths;
        }
        
		public static void manageHshtable( int key, int delat, Dictionary<int, int> count)
        {
			var newcount = 0;

			count.TryGetValue(key, out newcount); 
			newcount += delat;
			if(newcount ==0 && count.ContainsKey(key)){
				count.Remove(key);
			}else{
				count.Add(key,newcount);
			}
        }
        
   //     static void Main(string[] args)
   //     {

   //         var root = new TreeNode<int>(10);
   //         root.left = new TreeNode<int>(5);
   //         root.right = new TreeNode<int>(-3);
			//root.right.right = new TreeNode<int>(11);
   //         root.left.left = new TreeNode<int>(3);
   //         root.left.left.left = new TreeNode<int>(3);
			//root.left.left.right = new TreeNode<int>(-2);
			//root.left.right = new TreeNode<int>(1);
			//root.left.right.right = new TreeNode<int>(2);

            
   //         var output = Find1Sum(root, 0,8,new Dictionary<int, int>());
			//Console.WriteLine(output);
        //}
    }
}
