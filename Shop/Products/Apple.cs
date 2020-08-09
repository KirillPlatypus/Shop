using Users;
using CountPrices;

namespace Products
{
    class Apple : Product
    {
        internal override string Name { get; set; }
        internal override CountPrice Price { get; set; }

        internal Apple()
        {
            Name = "Apple";
            Price = new CountPrice(50);
        }


        internal override double SetPriceWithStock(User user, double price)
        {
            return price * 0.9;
        }

    }

}