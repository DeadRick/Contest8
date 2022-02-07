using System;

internal class Monster : Mob
{
    public Monster(int hp, int attack, int position) : base (hp, attack)
    {
        Position = position;
    }

    public int Position { get; set; }

    public void AttackHero(Mob hero, int position)
    {
        if (position == Position)
        {
            Console.WriteLine($"Mario meet monster on {position}");
            while (hero.HP > 0 && this.HP > 0)
            {
                Console.WriteLine(hero.ToString() + " attacked " + this.ToString());
                Console.WriteLine(this.ToString() + " attacked " + hero.ToString());
                hero.HP -= this.Attack;
                this.HP -= hero.Attack;
            }
        }
    }


    public override string ToString()
    {
        return $"Monster with HP = {HP} and attack = {Attack}";
    }
}