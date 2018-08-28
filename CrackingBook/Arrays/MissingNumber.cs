using System;
using System.Collections;
using System.Collections.Generic;

class MissingNumber
{
    // static void Main(string[] args)
    // {
    //     CollectAnagrams(new string[] { "aac", "bde", "caa", "dbe", "aca", "ebd", "edb", "ssss", "Murali", "almiur" });
    // }

    static void MissingNumberFind(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        //formuls sum = n(n-1)/2
        int N = arr.Length + 1; //zero based index
        int total = (N * (N + 1)) / 2;
        Console.WriteLine(total - sum);
    }

    static void MissingNumberXOR(int[] arr)
    {
        int x1 = arr[0];
        int x2 = 1;

        /* For xor of all the elements 
        in array */
        for (int i = 1; i < arr.Length; i++)
            x1 = x1 ^ arr[i];

        /* For xor of all the elements 
        from 1 to n+1 */
        for (int i = 2; i <= arr.Length + 1; i++)
            x2 = x2 ^ i;

        Console.WriteLine(x1 ^ x2);
    }
    //static void Main()
    //{
    //    //MissingNumberFind(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 });
    //    MissingNumberXOR(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 });

    //}



}


