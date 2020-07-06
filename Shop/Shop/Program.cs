using System;


namespace Shop
{
    class Program
    {
         
        static void Main(string[] args)
        {
            ICatalog catalog = new CatalogVegetables();
            User user = new User("Artem", 10000);

            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"{user.Name} " +
                                  $"your balance {user.Balance}," +
                                  $"you spend {user.Spend}");

                Console.WriteLine(" ");
                Console.WriteLine("1 - Catalog");
                Console.WriteLine("2 - Buy product");
                Console.WriteLine("0 - Exit");
                Console.WriteLine(" ");

                int Choice = checked(Convert.ToInt32(Console.ReadLine()));

                if (Choice is 1)
                {
                    catalog.ProductOutPut();
                }
                else if (Choice is 2)
                {
                    Console.WriteLine("Choice product(enter his number)");

                    int NumberProduct = checked(Convert.ToInt32(Console.ReadLine()));

                    CountPrice userPrice = new CountPrice(catalog.Products[NumberProduct].Price.price);          

                    if (user.BuyProduct(catalog.Products[NumberProduct].SetPriceWithStock(user, userPrice.SetPriseWhithKg())))
                    {

                        Information information = new Information();
                        information.InformationAboutOrdering(user, catalog.Products[NumberProduct]);
                    }
                }
                else if (Choice is 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Error. It is command don`t exist");
                }
            }
        }
    }
}


