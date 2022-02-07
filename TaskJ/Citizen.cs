using System;

internal class Citizen : IOptimist, IPessimist
{
    public int Salary { get; set; }
    public Citizen(int predictedValue)
    {
        Salary = predictedValue;
    }

    double IOptimist.GetForecast()
    {
        return Salary * 2.0;
    }

    double IPessimist.GetForecast()
    {
        return Salary * 0.6;
    }

    public double GetForecast()
    {
        return Salary + Salary * 0.1;
    }

    internal static Citizen Parse(string input)
    {
        if (int.TryParse(input, out int n))
        {
            return new Citizen(n);
        }
        throw new ArgumentException("Incorrect citizen");
    }
}