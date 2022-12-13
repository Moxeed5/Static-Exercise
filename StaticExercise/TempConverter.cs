using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StaticExercise
{
    //The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter and return a double, 
    //the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.


    internal class TempConverter
    {
        static TempConverter()
        {

        }

        internal static double FahrenheitToCelsius(double f)
        {
            double c = (f - 32) * .5556;

            return c;
        }

        internal static double CelsiusToFahrenheit(double c)
        {
            double f = (c * 1.8) + 32;

            return f;
        }


    }
}
