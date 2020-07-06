using System;
using System.Collections.Generic;

internal interface ICatalog
{
    List<Product> Products { get => new List<Product>(); set => Products = new List<Product>(); }
    void ProductOutPut();
}
internal class CatalogVegetables : ICatalog
{
    internal List<Product> _products = new List<Product>();
    public List<Product> Products { get { return _products; } }
    
    internal CatalogVegetables()
    {

        _products.Add(new Apple());
        _products.Add(new Banan());
        _products.Add(new Corn());
        _products.Add(new Potato());
        _products.Add(new Tomato());
        
        /*место для продуктов*/
    }
    public void ProductOutPut() // OutPut - вывод
    {
        
        for (int i = 0; i < Products.Count; i++)
        {
            Console.WriteLine($"{i}. { Products[i].Name}  { Products[i].Price.price} Rubles for 1Kg");
        }
              
    }

    
}
internal class CatalogFructs : ICatalog
{
    internal List<Product> _products = new List<Product>();
    public List<Product> Products { get { return _products; } }

    internal CatalogFructs()
    {
        /*место для продуктов*/
    }
    public void ProductOutPut()
    {
        for(int i = 0; i< Products.Count; i++)
        {
            Console.WriteLine($"{i}. { Products[i].Name}  { Products[i].Price.price} Rubles for 1Kg");
        }
    }
}
