using System;

internal class Round
{
    int amountOfMonsters;
    int amountOfCrashes;

    public Round(int amountOfMonsters, int amountOfCrashes)
    {
        this.amountOfCrashes = amountOfCrashes;
        this.amountOfMonsters = amountOfMonsters;


    }

    public void Play()
    {
        for (int i = 0; i < Game.helpers.Count; i++)
        {
            if ((Game.helpers[i] is Hero) || (Game.helpers[i] is Mario))
            {
                ((IHero)Game.helpers[i]).KillMonster(ref amountOfMonsters);
            }
            if ((Game.helpers[i] is Plumber) || (Game.helpers[i] is Mario))
            {
                ((IPlumber)Game.helpers[i]).FixPipe(ref amountOfCrashes);
            }

        }

        bool firstCase = false;
        bool secondCase = false;

        if (firstCase || secondCase)
        {
            Console.WriteLine("Helpers lost this round!");
        }

        if (amountOfCrashes > 0)
        {
            firstCase = true;
        }
        if (amountOfMonsters > 0)
        {
            secondCase = true;
        }

        if (firstCase || secondCase)
        {
            Console.WriteLine("Helpers lost this round!");
            if (firstCase)
            {
                if (secondCase)
                {
                    Game.helpers.Add(new Mario());
                    return;
                }
                else
                {
                    Game.helpers.Add(new Plumber());
                    return;
                }
            }
            else
            {
                Game.helpers.Add(new Hero());
                return;
            }
        }
        Console.WriteLine("Helpers won this round!");

    }
}