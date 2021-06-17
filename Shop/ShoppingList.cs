using System;
using System.Collections.Generic;
using Products;
using Users;

internal class HistoryList
{

    public List<Product> _listProduct  = new List<Product>();

    DateTime nowDate  = new DateTime();

    public List<DateTime> dateList = new List<DateTime>();

    public void AddPurchases( Product product, ref int numberLine)
    {
        _listProduct.Add(product);
        _listProduct[numberLine] = product;

        dateList.Add(nowDate);
        dateList[numberLine] = DateTime.UtcNow;

        numberLine++;

    }
   
    public void ListOutput(User user)
    {
        
        for (int i = 0;  i < _listProduct.Count; i++)
        {
            Console.WriteLine($"{user.Name} buy" +
                $" {_listProduct[i].Name} " +
                $"({_listProduct[i].SetPriceWithStock(user, _listProduct[i].Price.price)}) " +
                $" at {nowDate}");
        }
    }
}


