using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    class EnglishInt
    {
		static string[] smalls = new string[] {
                "Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten",
                "Eleven","Twelve","Thirteen","Forteen","Fifteen","Sixteen","Seventeen","Eighten","Nineteen"
            };
		static string[] tens = new string[] { "","","Twenty", "Thirty", "Forty", "Fifty", "Sixty" ,"Seventy","Eighty","Ninty"};
        static string[] bigs = new string[] { "", "Thousand", "Million", "Billion" };
        static string hundred = "Hundred";

		public static string convertInt(long num)
		{
			int chunkCount = 0;
			var chunk = new CrackingBook.Utils.Stack<string>();
			if(num == 0){
				return smalls[0];
			}else if(num < 0){
				return $"Negative {convertInt(-1 * num)}";
			}
            
            while (num > 0)
			{
				chunk.Push(CovertChunk(num % 1000) + " "  + bigs[chunkCount]);
				num /= 1000;
				chunkCount++;
			}
            
			return stackToString(chunk);
		}

		public static string CovertChunk(long num)
        {
			var temp = "";;
			if(num >= 100){
				temp += smalls[num / 100] + hundred;
				num %= 100;
			}

			if (num > 1 && num <= 19)
			{
				temp += smalls[num];
			}else{
				temp += tens[num / 10];
				num %= 10;
			}

			if(num >= 1 && num <= 9){
				temp += smalls[num];
			}


			return temp;
        }

		private static string stackToString(CrackingBook.Utils.Stack<string> stk){
			string chunk = "";
			while (!stk.IsEmpty())
			{
				chunk += stk.Pop() + " ";
			}
			return chunk;
		}


		//static void Main(string[] args)
        //{
        //    Console.WriteLine(convertInt(19234567084));
        //}
    }
}
