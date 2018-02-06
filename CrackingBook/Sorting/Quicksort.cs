using System;
using System.Collections;
using System.Collections.Generic;

class QuickSort
{
    //static void Main(string[] args)
    //{
    //    var arr = new int[] { 0, 7, 8, 9, 1, 5 };
    //    QuickSort1(arr, 0, arr.Length - 1);

    //    foreach (var item in arr)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}

    static void QuickSort1(int[] arr, int low, int high)
    {
        Console.WriteLine("low : " + low + " High : " + high);
        if (low < high)
        {
            //Partition
            var pi = Partition(arr, low, high);
            //sort left side
            QuickSort1(arr, low, pi - 1);
            //sort right side
            QuickSort1(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        var i = low - 1;
        if (low < high)
        {
          
            var pi = arr[high];

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pi)
                {
                    i++;
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            var temp2 = arr[high];
            arr[high] = arr[i + 1];
            arr[i + 1] = temp2;
        }
        Console.WriteLine("partition " + (i+1).ToString());
        return i + 1;
    }
}


