using System;
using System.Collections.Generic;

internal static class Methods
{
    public static int FindBestBiathlonistValue(List<Sportsman> sportsmen)
    {
        int bestVal = 0;

        foreach (var sprot in sportsmen)
        {
            if (sprot is Biathlonist)
            {
               
                IShooter shot = ((IShooter)sprot);
                ISkiRunner run = ((ISkiRunner)sprot);
                int b = ((int)(0.4 * Math.Max(shot.Shoot(), run.Run()) + 0.6 * Math.Min(shot.Shoot(), (run.Run()))));
                bestVal = Math.Max(bestVal, b);
            }
        }
        return bestVal;
    }

    public static int FindBestShooterValue(List<Sportsman> sportsmen)
    {
        int bestVal = 0;

        foreach (var sport in sportsmen)
        {
            if (sport is Shooter || sport is Biathlonist)
            {

                IShooter shoot = ((IShooter)sport);
                
                bestVal = Math.Max(shoot.Shoot(), bestVal);
            }
        }
        return bestVal;
    }

    public static int FindBestRunnerValue(List<Sportsman> sportsmen)
    {
        int bestVal = 0;

        foreach (var sport in sportsmen)
        {
            if (sport is SkiRunner || sport is Biathlonist)
            {
           

                bestVal = Math.Max(((ISkiRunner)sport).Run(), bestVal);
            }
        }
        return bestVal;
    }
}