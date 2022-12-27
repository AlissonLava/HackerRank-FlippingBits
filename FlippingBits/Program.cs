using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        string binResult = "";
        string bin = Convert.ToString(n, 2);
        string binFill = "00000000000000000000000000000000";


        bin = binFill.Substring(0, 32 - bin.Length) + bin;

        for (int i = 0; i < 32; i++)
        {
            if (bin.Substring(i, 1) == "0")
            {
                binResult += "1";
            }
            else
            {
                binResult += "0";
            }
        }

        return Convert.ToInt64(binResult, 2);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            Console.WriteLine(result);
        }

    }
}
