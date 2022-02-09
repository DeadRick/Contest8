internal class Mario : IHero, IPlumber
{
    void IHero.KillMonster(ref int numberOfMonsters)
    {
        if (numberOfMonsters > 0)
        {
            numberOfMonsters -= 1;
        }
    }

    void IPlumber.FixPipe(ref int numberOfCrashes)
    {
        if (numberOfCrashes > 0)
        {
            numberOfCrashes -= 1;
        }
    }
}