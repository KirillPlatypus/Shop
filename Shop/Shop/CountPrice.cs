using System;
class CountPrice
{
    public double price;
    HowKg Kg = new HowKg();

    internal CountPrice(double _priceForOneKg)
    {
        price = _priceForOneKg;
    }

    internal double SetPriseWhithKg()
    { 
        price *= Kg.SetUserKg();
        
        return price;
    }
}

public class HowKg
{
    private bool cycle = true;
    double Kg = 0.0f;
    public double SetUserKg()
    {


        while (cycle)
        {
            Console.WriteLine("Print product kg (Fractional number write with help ','): ");

            Kg = checked(Convert.ToDouble(Console.ReadLine())); // для ввода дробных чисел типа double необходимо использовать ',' 


            Console.WriteLine($"You wait take {Kg} Kg this product?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");

            int Change = checked(Convert.ToInt32(Console.ReadLine()));

            if (Change is 1)
            {
                Console.WriteLine("We understood you");
                cycle = false;
            }
            else if (Change is 0)
            {
                continue;
            }
            else
            {
                Console.WriteLine("this choice don`t exist");

            }

        }
        return Kg;
    }
}


