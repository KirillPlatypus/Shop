using Users;
using CountPrices;

namespace Products
{
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

}