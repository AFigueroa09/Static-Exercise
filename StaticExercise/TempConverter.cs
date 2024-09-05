using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double temp)
        {
            // (Fahrenheit - 32) / 1.8
            return (temp - 32) / 1.8;
        }

        public static double CelciusToFahrenheit(double temp)
        {
            //  (°C x 1.8) + 32 
            return (temp * 1.8) + 32;
        }
    }
}
