using System;
using System.Collections;
using System.Collections.Generic;

class SelectionSort
{
    // static void Main(string[] args)
    // {
    //     SelectSort(new int[] { 0, 2, 1, -3, 4, 5, 8, 6, 7 });
    // }

    static void SelectSort(int[] arr)
    {
        var count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            var temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }


}


