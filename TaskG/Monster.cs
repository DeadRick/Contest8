using System;

internal class Monster : Mob
{


    public int Position { get; set; }

    public Monster(int hp, int attack, int position) : base(hp, attack)
    {
        Position = position;
    }

    public void AttackHero(Mob hero, int position)
    {
       
        if (position == Position)
        {
            Console.WriteLine($"Mario meet monster on {position}");

            while (IsDead(hero) && IsDead(this))
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