 using System;
using System.Collections.Generic;

internal class Game
{
    int Heros, Plumbers, Marios, Rounds, enemy, pipe;
    int cnt = 0;
    public static IList<IHelper> helpers = new List<IHelper>();

    public Game(int numberOfHeroes, int numberOfPlumbers, int numberOfMarios, int numberOfRounds)
    {
        while (cnt < numberOfHeroes)
        {
            helpers.Add(new Hero());
            cnt += 1;
        }
        cnt = 0;

        while (cnt < numberOfPlumbers)
        {
            helpers.Add(new Plumber());
            cnt += 1;
        }
        cnt = 0;

        while (cnt < numberOfMarios)
        {
            helpers.Add(new Mario());
            cnt += 1;
        }
        cnt = 0;
        
        this.Heros = numberOfHeroes;
        this.Plumbers = numberOfPlumbers;
        this.Marios = numberOfMarios;
        this.Rounds = numberOfRounds;

    }

    public void Play()
    {
        for (int i = 0; i < Rounds; i++)
        {
            string[] str = Console.ReadLine().Split();
            if (str.Length == 2)
            {
                if ((int.TryParse(str[0], out int n)) && (n >= 0) && (int.TryParse(str[1], out n)) && (n >= 0))
                {
                    int monster = i;
                    for (int j = 0; j < monster; j++)
                    {
                        monster += 1;
                    }
                    pipe = (int)uint.Parse(str[1]);
                    enemy = (int)uint.Parse(str[0]);
                    Round rnd = new Round(enemy, pipe);
                    rnd.Play();
                }
            }
            else
            { 
                Console.WriteLine("Incorrect data!");
                i--;
            }
        }
    }
}