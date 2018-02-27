using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Stack
{
    public class MaxStack
    {
        //        You have an empty sequence, and you will be given queries.Each query is one of these three types:

        //1 x  -Push the element x into the stack.
        //2    -Delete the element present at the top of the stack.
        //3    -Print the maximum element in the stack.
        //Input Format

        //The first line of input contains an integer, . The next  lines each contain an above mentioned query. (It is guaranteed that each query is valid.)

        //Constraints



        //Output Format

        //For each type  query, print the maximum element in the stack on a new line.

        //Sample Input

        //10
        //1 97
        //2
        //1 20
        //2
        //1 26
        //1 20
        //2
        //3
        //1 91
        //3
        //Sample Output

        //26
        //91
        public void test()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1 && n > Math.Pow(10, 5))
            {
                return;
            }
            var stack = new Stack<int>();
            int max = 0;
            int min = 0;
            for (var i = 0; i < n; n++)
            {
                var query = Console.ReadLine().Split(' ');
                switch (Convert.ToInt16(query[0])) //2,4,1,9
                {
                    case 1:
                        var temp = Convert.ToInt32(query[1]);
                        if (temp < 1 && temp > Math.Pow(10, 9))
                        {
                            return;
                        }
                        stack.Push(Convert.ToInt16(temp));
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        Console.WriteLine(stack.Max());
                        break;
                    default:
                        throw new Exception("Invalid Input");
                }
            }
        }

    }
}

//Stack<Character> stack = new Stack<>();
//char upperElement = 0;
//        for (int i = 0; i<value.length(); i++) {
//            if (!stack.isEmpty()) {
//                upperElement = stack.peek();
//            }
//            stack.push(value.charAt(i));
//            if (!stack.isEmpty() && stack.size() > 1) {
//                if ((upperElement == '[' && stack.peek() == ']') ||
//                        (upperElement == '{' && stack.peek() == '}') ||
//                        (upperElement == '(' && stack.peek() == ')')) {
//                    stack.pop();
//                    stack.pop();
//                }
//            }
//        }
//        return stack.isEmpty() ? "YES" : "NO";
