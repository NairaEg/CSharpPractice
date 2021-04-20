using System;
using System.Collections.Generic;
using System.Text;

namespace KelvinFarenheitCelsia
{
    class Celsia
    {
        public float TempInCelsia { get; set; }
        public Celsia(float Temp)
        {
            TempInCelsia = Temp;
        }
        public Celsia()
        {

        }
        public static implicit operator Farenheit (Celsia temp)
        {
            
            return new Farenheit {TempInFarenheit=temp.TempInCelsia * 9f / 5f + 32f };
        }
        
    }
}
