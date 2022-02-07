using System;

internal class Kikstarter
{
    // Данный тип необходимо обязательно использовать
    public delegate void GetMoneyDelegate();
    public GetMoneyDelegate getGetGet = null;
    public int[] numOfHipsters;  
    public int _money;
    public Kikstarter(int money, Hipster[] hipsters)
    {
        if (hipsters.Length == 0)
        {
            throw new ArgumentException("Not enough hipsters");
        }
        _money = money;
        numOfHipsters = new int[hipsters.Length];

        for (int i = 0; i < hipsters.Length; i++)
        {
            int i_1 = i;
            getGetGet += delegate
            {
                Hipster man = hipsters[i_1];
                if (man.Donate + numOfHipsters[i_1] > man.Money) 
                {
                    numOfHipsters[i_1] += man.Money - numOfHipsters[i_1];
                } else
                {
                    numOfHipsters[i_1] += man.Donate;
                }
            };
        }
    }

    public int Run()
    {
        int sum = 0;
        int cnt = 0;
        int preSum;

        while (sum < _money)
        {
            preSum = sum;
            sum = 0;

            getGetGet.Invoke();
            cnt += 1;

            for (int i = 0; i < numOfHipsters.Length; i++)
            {
                sum += numOfHipsters[i];
            }
            if (sum == preSum)
            {
                throw new ArgumentException("Not enough money");
            }
        }
        return cnt;
    }
}