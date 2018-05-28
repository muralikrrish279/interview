using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
	public class Calculator
	{
		//static void Main(string[] args)
		//{
		//	//Console.WriteLine(Compute("2-6-7*8/2+5"));
		//	Console.WriteLine(Compute("2*3+5/6*3+15"));
            
		//}

		static double Compute(string expr){
			var numStack = new Utils.Stack<double>();
            var opStack = new Utils.Stack<char>();
			for (int i = 0; i < expr.Length; i++)
			{
				var value = findNextNumber(expr, i);
				numStack.Push(value);

				i += value.ToString().Length;

				if (i >= expr.Length){
					break;                    
				}

                collapseOp(numStack, opStack, expr[i]);
				opStack.Push(expr[i]);               

			}

			if(opStack.Count() == 1 && numStack.Count() == 2){
				collapseOp(numStack, opStack, opStack.Peek());
			}

			if (numStack.Count() == 1)
			{
				return numStack.Pop();
			}

			throw new InvalidOperationException();
		}

		static void collapseOp(Utils.Stack<double> numStacks,Utils.Stack<char> opStack,char currentOp){
			while(numStacks.Count() >= 2 && opStack.Count() >= 1)
			{
				if (OpPriority(currentOp) <= OpPriority(opStack.Peek())) 
				{
					var num2 = numStacks.Pop();
					var num1 = numStacks.Pop();
					var op = opStack.Pop();
					var result = applyOp(num1, num2, op);
					numStacks.Push(result);
				}else{
					break;
				}
			}
		}

		static double applyOp(double left,double right,char op){
			switch (op)
			{
				case '+':
					return left + right;
				case '-':
                    return left - right;
				case '*':
                    return left * right;
				case '/':
                    return left / right;
				default:
					return right;
			}
		}

		static int OpPriority(char op){
			switch (op)
			{
				case '*': case'/':
					return 2;
				case '+':
                case '-':
                    return 1;
				default:
					return 0;
			}
		}

		static int findNextNumber(string expr,int index){
			var res = "";
			var arr = expr.ToCharArray();
			while (index < expr.Length && char.IsDigit(arr[index]))
			{
				res += arr[index] - 48;
				index++;
			}
			return int.Parse(res);
		}


	}
}

