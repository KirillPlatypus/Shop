using System;
using Catalog;
using Users;
using CountPrices;

namespace Shop
{
    class Interface
    {

        static void Main(string[] args)
        {
            ICatalog catalog = new CatalogVegetables();
            User user = new User("Artem", 10000);
            HistoryList shoppingLists = new HistoryList();
            int NumberProduct;
            int numberLine = 0;

            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"{user.Name} " +
                                  $"your balance {user.Balance}," +
                                  $"you spend {user.Spend}");

                Console.WriteLine(" ");
                Console.WriteLine("1 - Catalog");
                Console.WriteLine("2 - Buy product");
                Console.WriteLine("3 - Shopping list ");
                Console.WriteLine("0 - Exit");
                Console.WriteLine(" ");

                int Choice = checked(Convert.ToInt32(Console.ReadLine()));

                switch (Choice)
                { 
                    case 1:

                        catalog.ProductOutPut();

                        break;
                case 2:

                        Console.WriteLine("Choice product(enter his number)");

                        NumberProduct = checked(Convert.ToInt32(Console.ReadLine()));

                        //

                        CountPrice userPrice = new CountPrice(catalog.Products[NumberProduct].Price.price);

                        if (user.BuyProduct(catalog.Products[NumberProduct].SetPriceWithStock(user, userPrice.SetPriseWithKg())))
                        {
                            Information information = new Information();


                            shoppingLists.AddPurchases(catalog.Products[NumberProduct], ref numberLine);

                            information.InformationAboutOrdering(user, catalog.Products[NumberProduct]);
                        }

                        break;

                    case 3:

                        if (shoppingLists != null)
                        {
                            shoppingLists.ListOutput(user);
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }

                        break;

                    case 0:

                        return;

                    default:

                        Console.WriteLine("Error. It is command don`t exist");
                        break;

                }
            }
        }
    }
}