using System;

internal class Information
{
    public void InformationAboutOrdering(User _user, Product _product)
    {
        Console.WriteLine($"{_user.Name}, {_product.Name}  is buying");
    }
}


