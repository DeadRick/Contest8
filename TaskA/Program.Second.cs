using System;

internal partial class Program
{
    public static int SecondInArray(int[] arr)
    {
        int max = int.MinValue;
        int perMax = -666;

        Array.Sort(arr);


        foreach (var item in arr)
        {
            if (item >= max)
            {
                perMax = max;
                max = item;
            }
        }

        if (perMax == int.MinValue)
        {
            throw new ArgumentException("Not enough elements");
        } return perMax;

    }
}