internal class Plumber : IPlumber
{
    void IPlumber.FixPipe(ref int numberOfCrashes)
    {
        numberOfCrashes -= 1;
    }
}