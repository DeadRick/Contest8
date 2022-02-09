using System;

#pragma warning disable
public delegate double Calculator(ref double num);

internal class StackCalculator : Program
{

    public static void CreateRules(int[] args)
    {

        foreach (var func in args)
        {
            if (func == 0) { calculator += (ref double x) => x = Math.Sin(x); }
            if (func == 1) { calculator += (ref double x) => x = Math.Cos(x); }
            if (func == 2) { calculator += (ref double x) => x = Math.Tan(x); }
        }
    }
}
