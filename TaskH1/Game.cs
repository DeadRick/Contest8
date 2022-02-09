using System;
using System.Collections.Generic;

internal class Game
{
    int numberOfHeroes;
    int numberOfPlumbers;
    int numberOfMarios;
    int numberOfRounds;
    int monsters;
    int trub;

    public static IList<IHelper> helpers = new List<IHelper>();

    public Game(int numberOfHeroes, int numberOfPlumbers, int numberOfMarios, int numberOfRounds)
    {
        for (int i = 0; i < numberOfHeroes; i++)
        {
            helpers.Add(new Hero());
        }
        for (int i = 0; i < numberOfPlumbers; i++)
        {
            helpers.Add(new Plumber());
        }
        for (int i = 0; i < numberOfMarios; i++)
        {
            helpers.Add(new Mario());
        }
        this.numberOfHeroes=numberOfHeroes;
        this.numberOfPlumbers=numberOfPlumbers;
        this.numberOfMarios=numberOfMarios;
        this.numberOfRounds=numberOfRounds;

    }

    public void Play()
    {
        for (int i = 0; i < numberOfRounds; i++)
        {

            
                string[] s = Console.ReadLine().Split();
            if(s.Length==2&&int.TryParse(s[0],out int t)&& t>=0&&int.TryParse(s[1], out t) && t >= 0 ) 
            { 
                monsters = (int)uint.Parse(s[0]);
                trub = (int)uint.Parse(s[1]);
                Round a = new Round(monsters, trub );
                a.Play();
            }
            else
            {
                i--;
                Console.WriteLine("Incorrect data!");
            }
        }
    }
}