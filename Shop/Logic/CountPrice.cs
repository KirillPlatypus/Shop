using System;
namespace CountPrices
{
    class CountPrice
    {
        public double price;
        internal double Kg = 0.0f;

        internal CountPrice(double _priceForOneKg)
        {
            price = _priceForOneKg;
        }

        internal double SetPriseWithKg()
        {
            Console.WriteLine("Print product kg (Fractional number write with help ','): ");

            Kg = checked(Convert.ToDouble(Console.ReadLine())); // для ввода дробных чисел типа double необходимо использовать ',' 
            
            price *= Kg;

            return price;
        }
    }
}
   
