using System;
using System.Collections;
using System.Collections.Generic;
public class PrintBinaryNumbers
{

    // public static void Main(string[] args)
    // {
    //     PrintBinary(10);
    // }

    public static void PrintBinary(int digits)
    {
        PrintBinaryHelper(digits, "");
    }

    public static void PrintBinaryHelper(int digits, string prefix)
    {
        if (digits == 0)
        {
            Console.WriteLine(prefix);
        }
        else
        {
            PrintBinaryHelper(digits - 1, prefix + "0");
            PrintBinaryHelper(digits - 1, prefix + "1");
        }

    }
}