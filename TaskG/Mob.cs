using System;

internal abstract class Mob : Program
{
    public int HP { get; set; }
    public int Attack { get; }

    public Mob(int hp, int attack)
    {
        HP = hp;
        Attack = attack;
    }

    public bool IsDead(Mob other)
    {
        if (other.HP > 0)
        {
            return true;
        } return false;
    }

    public virtual void AttackMob(Mob boss)
    {
        while (IsDead(this) && IsDead(boss))
        {
            Console.WriteLine($"{this.ToString()} attacked {boss.ToString()}");
            Console.WriteLine($"{boss.ToString()} attacked {this.ToString()}");
            this.HP -= boss.Attack;
            boss.HP -= this.Attack;
        }
    }

    public override string ToString()
    {
        return $"{this.GetType()} with HP = {HP} and attack = {Attack}";
    }
}