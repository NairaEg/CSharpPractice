using System;
using System.Collections.Generic;
using System.Text;

namespace KelvinFarenheitCelsia
{
    class Farenheit
    {
        public float TempInFarenheit { get; set; }
        public Farenheit(float Temp)
        {
                TempInFarenheit = Temp;
        }
        public Farenheit()
        {

        }

        public static implicit operator Farenheit(Kelvin v)
        {
            throw new NotImplementedException();
        }
    }
}
