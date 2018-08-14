using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CrackingBook.Strings
{
	public class multiplyLargeNumber
	{
		//123
		// * 32
		//-----
		//  246
		// 369
		//------
		// 3936
		static string multiply(string a, string b)
		{
			int digitShifti = 0;
			int digitShiftj = 0;

			//number will be stored in reverse order as we go right to left
			int[] lastCalculated = new int[a.Length + b.Length];
			for (var i = a.Length - 1; i >= 0; i--)
			{
				int carry = 0;
				int numberi = Convert.ToInt16(a[i].ToString());
				digitShiftj = 0;

				var j = b.Length - 1;
				while (j >= 0)
				{
					var numberj = Convert.ToInt16(b[j].ToString());
					int result = (numberi * numberj) + lastCalculated[digitShifti + digitShiftj] + carry;
					carry = result / 10;
					lastCalculated[digitShifti + digitShiftj] = result % 10;

					j--;
					digitShiftj++;
				}

				if (carry > 0)
				{
					lastCalculated[digitShifti + digitShiftj] += carry;
				}
				digitShifti++;

			}

			var stringBuilder = new StringBuilder("");
			for (int i = lastCalculated.Length - 1; i >= 0; i--)
			{
				stringBuilder.Append(lastCalculated[i]);
			}

			string trimmedResult = stringBuilder.ToString().TrimStart('0');
			if (trimmedResult.Length > 0)
			{
				return trimmedResult;
			}
			else
			{
				return "0";
			}

		}

		static void Main(string[] args)
		{
			//Test Cases
			//Console.WriteLine(multiply("123", "32"));
			//Console.WriteLine(multiply("0", "0"));
			//Console.WriteLine(multiply("123456789", "123456789123456789123456789"));
			//Console.WriteLine(multiply("", "32"));
			//Console.WriteLine(multiply("0000", "000"));
		}
	}


}
