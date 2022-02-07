using System;

internal partial class Program
{
    public static int CompareLength(int a, int b)
    {
        return a.ToString().Length.CompareTo(b.ToString().Length);
    }
    public static int[] StrangeSort(int[] arr)
    {
        int[] newArr = (int[])arr.Clone();
        Comparison<int> comp = new(CompareLength);
        Array.Sort(newArr, comp);

        return newArr;
    }
}