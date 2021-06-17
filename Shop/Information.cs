using System;
using System.Threading.Tasks;
using Products;
using Users;

internal class Information
{
    public void InformationAboutOrdering(User _user, Product _product)
    {
        Console.WriteLine($"{_user.Name}, {_product.Name}  is buying");
    }
}


