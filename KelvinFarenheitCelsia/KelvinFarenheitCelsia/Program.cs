using System;

namespace KelvinFarenheitCelsia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the teperature in Celsia");
            float.TryParse(Console.ReadLine(), out float temperature);

            Celsia tempCel = new Celsia {TempInCelsia=temperature };

            Farenheit tempFarenheitFromCelsia = tempCel;
            Console.WriteLine($"{temperature} in celsia = {tempFarenheitFromCelsia.TempInFarenheit} in farenheit");

            Kelvin tempKelvinFromeCelsia =(Kelvin) tempCel;
            Console.WriteLine($"{temperature} in celsia = {tempKelvinFromeCelsia.TempInKelvin} in kelvin");

           
            
        }

    }
}
