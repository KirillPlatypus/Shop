using System;

class User
{
    public string Name;
    public double Balance;
    public double Spend;
    internal User(string name, float balance)
    {
        Name = name;
        Balance = balance;
    }
    internal bool BuyProduct(double money)
    {
        if (Balance >= money)
        {
            Balance -= money;
            Spend += money;
            return true;
        }
        else
        {
            Console.WriteLine("You don`t have money, how ever))))))");
            return false;
        }
    }
}

