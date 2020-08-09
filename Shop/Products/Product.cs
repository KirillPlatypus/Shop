using Users;
using CountPrices;

namespace Products
{
    internal abstract class Product
    {
        internal abstract string Name { get; set; }
        internal abstract CountPrice Price { get; set; }

        internal  virtual double SetPriceWithStock(User user, double price)
        {
            if (user.Spend  <= 200)
            {
                 return price;
            }
            else if (user.Spend >= 1000)
            {
                return price * 0.8f;
            }
            return price * 0.9f;
        }
    }

}