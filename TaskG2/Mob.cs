using System;

internal abstract class Mob
{
    public int HP { get; set; }
    public int Attack { get; }

    public Mob(int hp, int attack)
    {
        HP = hp;
        Attack = attack;
    }
}