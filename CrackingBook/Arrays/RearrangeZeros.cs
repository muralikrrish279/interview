using System;
using System.Collections;
using System.Collections.Generic;

class RearrangeZeros
{
    // static void Main(string[] args)
    // {
    //     //RearrangeZerosEnd(new int[] { 0, 1, 0, 2, 0, 4, 5, 6 });
    //     RearrangeZerosFront(new int[] { 0, 1, 0, 2, 0, 4, 5, 6 });
    //     //RearrangeZerosPositivesNegatives(new int[] { -1,2,3,-4,8,-3,19,-6});
    // }

    static void RearrangeZerosEnd(int[] numbers)
    {
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != 0)
            {
                numbers[count] = numbers[i];
                count++;
            }
        }

        while (count < numbers.Length)
        {
            numbers[count] = 0;
            count++;
        }

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }     
    }

       static void RearrangeZerosFront(int[] numbers)
    {
        int zeroCount = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                zeroCount++;
                numbers[i] = numbers[zeroCount - 1];
                numbers[zeroCount - 1] = 0;
            }
        }

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }     
    }

     static void RearrangeZerosPositivesNegatives(int[] numbers)
    {
        int negativeCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                var temp = numbers[negativeCount];
                numbers[negativeCount] = numbers[i]; 
                numbers[i] = temp;
                negativeCount++;
            }
        }

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }     
    }



}


