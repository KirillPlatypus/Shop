using System;
using Users;
using CountPrices;

namespace Products
{
    class Tomato : Product
    {
        internal override string Name { get; set; }
        internal override CountPrice Price { get; set; }

        internal Tomato()
        {
            Name = "Tomato";
            Price = new CountPrice(10);
        }


        internal override double SetPriceWithStock(User user, double price)
        {
            return price * 0.1;
        }
        private void SecretMessege() { Console.WriteLine("Чтобы закидать автора кода"); }
    }

}