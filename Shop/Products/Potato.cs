using Users;
using CountPrices;

namespace Products
{
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

}