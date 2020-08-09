using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Products;

namespace Catalog
{
    internal class CatalogVegetables : ICatalog
    {
        private List<Product> _products = new List<Product>();
        public IReadOnlyList<Product> Products { get { return _products; } }

        internal  CatalogVegetables()
        {
            _products.Add(new Apple());
            _products.Add(new Banan());
            _products.Add(new Corn());
            _products.Add(new Potato());
            _products.Add(new Tomato());

            /*место для продуктов*/
        }
        public  void  ProductOutPut() // OutPut - вывод
        {
            for (int i = 0; i < Products.Count; i++)
            {       
                Console.WriteLine($"{i}. { Products[i].Name}  { Products[i].Price.price} Rubles for 1Kg");
               
            }

        }


    }
}