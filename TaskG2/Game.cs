using System;
internal delegate void AttackHeroOnPosition(Mob mob, int position);

internal class Game
{
    private readonly Hero hero;
    private readonly Boss boss;

    public AttackHeroOnPosition attackHero = null;

    public Game(int castlePosition, int countOfMonsters, Hero hero, Boss boss)
    {
        CastlePosition = castlePosition;
        CountOfMonsters = countOfMonsters;
        this.hero = hero;
        this.boss = boss;
    }

    public int CastlePosition { get; set; }
    public int CountOfMonsters { get; set; }

    public void Play()
    {
        int startHP = hero.HP;
        for (int i = 0; i < CastlePosition; i++)
        {
            if (hero.HP <= 0)
            {
                Console.WriteLine("You Lose! Game over!");
                return;
            }
            attackHero?.Invoke(hero, i);
        }

        while (hero.HP > 0 && boss.HP > 0)
        {
            Console.WriteLine(hero.ToString() + " attacked " + boss.ToString());
            Console.WriteLine(boss.ToString() + " attacked " + hero.ToString());
            hero.HP -= boss.Attack;
            boss.HP -= hero.Attack;
        }

        if (hero.HP <= 0)
        {
            Console.WriteLine("You Lose! Game over!");
            return;
        }

        if (hero.HP >= startHP * 0.75)
        {
            Console.WriteLine("You win! Princess released!");
        }
        else
        {
            Console.WriteLine("Thank you, Mario! But our princess is in another castle... You lose!");
        }
    }
}