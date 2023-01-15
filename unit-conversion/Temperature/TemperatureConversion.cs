using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Temperature
{
    public class TemperatureConversion
    {
        private Dictionary<string, Type> UnitList = new Dictionary<string, Type>();
        public static string Celcius { get; } = "Celcius";
        public static string Fahrenheit { get; } = "Fahrenheit";
        public static string Kelvin { get; } = "Kelvin";

        public TemperatureConversion()
        {
            UnitList.Add(Celcius, typeof(ConvertFromCelcius));
            UnitList.Add(Fahrenheit, typeof(ConvertFromFahrenheit));
        }

        public decimal convert(string convertFrom, string converTo, decimal value)
        {
            IUnitConversion temperatureConversion = (IUnitConversion)Activator.CreateInstance(UnitList[convertFrom])!;

            return temperatureConversion.convert(converTo, value);
        }
    }
}
