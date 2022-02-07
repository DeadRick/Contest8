using System;

internal class Program
{
    static Func<double, double> Calculate = (x) =>
    {
        double sum = 0;

        for (int i = 1; i <= 5; i++)
        {
            double summ = 1;

            for (int j = 1; j <= 5; j++)
            {
                summ *= ((i + 42) * x) / (j * j);
            }
            sum += summ;
        }

        return sum;
    };
    private static void Main(string[] args)
    {
        double.TryParse(Console.ReadLine(), out double x);
        Console.WriteLine(Calculate(x).ToString("f3"));
    }
}