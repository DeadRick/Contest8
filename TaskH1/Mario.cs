internal class Mario : IHero, IPlumber
{
    void IPlumber.FixPipe(ref int numberOfCrashes)
    {
        numberOfCrashes--;
    }

    void IHero.KillMonster(ref int numberOfMonsters)
    {
        numberOfMonsters--;
    }
}