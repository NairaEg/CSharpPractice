using System;
using System.Collections.Generic;
using System.Text;

namespace KelvinFarenheitCelsia
{
    class Kelvin
    {
        public float TempInKelvin { get; set; }
        public Kelvin(float Temp)
        {
            TempInKelvin = Temp;
        }
        public Kelvin()
        {

        }

        public static explicit operator Kelvin(Celsia temp)
        {
            return new Kelvin { TempInKelvin = temp.TempInCelsia + (float)273.15 };
        }
    }
}
