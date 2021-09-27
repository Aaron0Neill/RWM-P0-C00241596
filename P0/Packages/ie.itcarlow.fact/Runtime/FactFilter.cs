using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactFilter
{
    public static int getFact(int x)
    {
        if (x <= 1)
            return x;

        int total = x;
        while (x > 1)
        {
            x--;
            total *= x;
        }
        return total;
    }

    public static int[] Factorial(int[] arr)
    {
        if (arr.Length > 0)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                result[i] = getFact(arr[i]);

            return result;
        }
        return new int[1] { 0};
    }
}