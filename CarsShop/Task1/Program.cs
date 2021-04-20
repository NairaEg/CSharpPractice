using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            CarsShop carsShop = new CarsShop();
            while (true)
            {
                Console.WriteLine("Entar the car's model: Kia, Audi or Ford");
                CarsBrand costomersCarsBrand = (CarsBrand)Enum.Parse(typeof(CarsBrand), Console.ReadLine(), ignoreCase: true);

                Console.WriteLine("How much will you pay");
                decimal.TryParse(Console.ReadLine(), out decimal costomersPrice);

                carsShop.SearchModel(costomersCarsBrand, costomersPrice);

                Console.WriteLine("If you want to buy the car please enter carsID else enter \"0\"  to continue ");
                string carsID = Console.ReadLine();
                if(carsID=="0")
                {
                    break;
                }
                else
                {
                    carsShop.CellCar(carsID);
                    Console.WriteLine();
                }

                Console.WriteLine("Enter any button to continue shopping or \"C\" for close");
                string enter = Console.ReadLine();
                if(enter.ToLower()=="c")
                {
                    break;
                }
            }
        }
        

       

    }
}
