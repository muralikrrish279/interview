﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using CrackingBook.Utils;

namespace CrackingBook
{
   
    public class CheckPrime
    {
        public static void ChekP(int n) /// O(n) solution
        {
            if(n == 1){
                Console.WriteLine("Yes");
            }

            for (int i = 2; i < n; i++)
            {
                if(n%i == 0){
                    Console.WriteLine("No");
                    return;
                }

            }
            Console.WriteLine("Yes");

        }

		//static void Main(string[] args)
		//{
		//    ChekP(22);
		//}

	}
}
