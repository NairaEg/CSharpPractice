using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class CarsShop
    {
        public List<Car> Cars = new List<Car>();
        readonly int carsCountInShop = 20;
        public CarsShop()
        {
            addCarsInList();
        }
        public void addCarsInList()
        {
            for (int i = 0; i < carsCountInShop; i++)
            {
                Car car = new Car();
                Cars.Add(car);

                car.PrintInformation();

                Console.WriteLine();
            }
        }
         
        public void CellCar( string carID)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if(carID==Cars[i].ID)
                {
                    Console.WriteLine($"Congratuations, you just bought the {Cars[i].brand}");
                    Cars.Remove(Cars[i]);
                    
                    break;
                }
            }
        }
        public void SearchModel(CarsBrand costomersCarsBrand, decimal costomersPrice)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if (costomersCarsBrand == Cars[i].brand && costomersPrice >= Cars[i].price)
                {
                    Cars[i].PrintInformation();
                    Console.WriteLine();
                }
            }

        }

    }
}
