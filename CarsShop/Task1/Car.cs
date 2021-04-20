using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public enum CarsBrand
    {
        Audi,
        Ford,
        Kia
    }

    public enum CarsColor
    {
        Black,
        Blue,
        White,
        Red
    }

    class Car
    {
        public string ID { get; set; }
        public CarsBrand brand;
        private string carsModel;
        CarsColor color;
        public readonly decimal price;
        
        
        static int counter = 7458;

        public Car()
        {
            ID = GenerateID(ref counter);
            brand = GenerateCarsBrand();
            carsModel = GenerateCarsModel(brand);
            color = GenerateCarsColor();
            price = GeneratePrice();
        }

        string GenerateID( ref int counter)
        {
            ID = counter.ToString();
            counter++;
            return ID;
        }

        string GenerateCarsModel(CarsBrand brand)
        {
            Random rnd = new Random();
            int key = rnd.Next(1 ,4);

            return brand.ToString() + "_Model"+ key.ToString();
        }

        CarsColor GenerateCarsColor()
        {
            Random rnd = new Random();
            int key = rnd.Next(0, 5);

            return (CarsColor)key;
        }

        CarsBrand GenerateCarsBrand()
        {
            Random rnd = new Random();
            int key = rnd.Next(0, 3);

            return (CarsBrand)key;

        }

        decimal GeneratePrice ()
        {
            Random rnd = new Random();
            decimal price = rnd.Next(2500, 35000);

            return price;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"CarID={this.ID}");
            Console.WriteLine($"CarsBrand={this.brand}");
            Console.WriteLine($"CarsModel={this.carsModel}");
            Console.WriteLine($"CarsColor={this.color}");
            Console.WriteLine($"CarsPrice={this.price}");
        }

    }
}