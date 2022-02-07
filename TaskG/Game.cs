using System;
delegate void AttackHeroOnPosition(Mob mob, int position);

internal class Game 
{
    public int CastlePosition { get; set; }
    public int CountOfMonsters { get; set; }
    private readonly Hero hero;
    private readonly Boss boss;
    public AttackHeroOnPosition attackHero = null;
 
    public void GameOver()
    {
        Console.WriteLine("You Lose! Game over!");
    }

    public void CheckHP()
    {
        if (hero.HP <= 0)
        {
            GameOver();
            return;
        }
    }

    public Game(int castlePosition, int countOfMonsters, Hero hero, Boss boss)
    {
        CastlePosition = castlePosition;
        CountOfMonsters = countOfMonsters;
        this.hero = hero;
        this.boss = boss;
    }

    public void Play()
    {

        double endHeroHp = hero.HP * 0.75;
        for (int i = 0; i < CastlePosition; i++)
        {
            CheckHP();
            attackHero?.Invoke(hero, i);
        }
        hero.AttackMob(boss);
        CheckHP();
        if (hero.HP >= endHeroHp)
        {
            Console.WriteLine("You win! Princess released!");
            return;
        }
        Console.WriteLine("Thank you, Mario! But our princess is in another castle... You lose!");
        return;
    }
}