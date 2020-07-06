using System;
internal abstract class Product
{
    internal abstract string Name { get; set; }
    internal abstract CountPrice Price { get; set; }

    internal virtual double SetPriceWithStock(User user, double price) 
    {
        if(user.Spend <= 200)
        {
            return price;
        }
        else if(user.Spend >= 1000)
        {
            return price * 0.8f;
        }
        return price * 0.9f;
    }
}


class Banan : Product
{
    internal override string Name { get; set; }
    internal override CountPrice Price { get; set; }
    internal Banan()
    {
        Name = "Banan";
        Price = new CountPrice(80);
    }



    internal override double SetPriceWithStock(User user, double price)
    {
        return price * 0.5;
    }
}
class Apple : Product
{
    internal override string Name { get; set; }
    internal override CountPrice Price { get; set; }

    internal Apple()
    {
        Name = "Apple";
        Price = new CountPrice(50);
    }


    internal override double SetPriceWithStock(User user, double price)
    {
        return price * 0.9;
    }

}
class Potato : Product
{
    internal override string Name { get; set; }
    internal override CountPrice Price { get; set; }
    internal Potato()
    {
        Name = "Potato";
        Price = new CountPrice(1000);
    }


    internal override double SetPriceWithStock(User user, double price)
    {
        return price * 0.0;
    }
}
class Corn : Product
{
    internal override string Name { get; set; }
    internal override CountPrice Price { get; set; }

    internal Corn()
    {
        Name = "Corn";
        Price = new CountPrice(1);
    }


    internal override double SetPriceWithStock(User user, double price)
    {
        return price;
    }
}
class Tomato : Product
{
    internal override string Name { get; set; }
    internal override CountPrice Price { get; set; }

    internal Tomato()
    {
        Name = "Tomato";
        Price = new CountPrice(10);
    }


    internal override double SetPriceWithStock(User user, double price)
    {
        return price * 0.1;
    }
    private void SecretMessege() { Console.WriteLine("Чтобы закидать автора кода"); }
}

