using Users;
using CountPrices;

namespace Products
{
    class Corn : Product
    {
        internal override string Name { get; set; }
        internal override CountPrice Price { get; set; }

        internal Corn()
        {
            Name = "Corn";
            Price = new CountPrice(1);
        }


        internal override double SetPriceWithStock(User user, double price)
        {
            return price;
        }
    }

}