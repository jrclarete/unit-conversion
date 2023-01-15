using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Temperature
{
    public class TemperatureConversion
    {
        private Dictionary<string, Type> UnitDict = new Dictionary<string, Type>();
        public static string CELSIUS { get; } = "Celsius";
        public static string FAHRENHEIT { get; } = "Fahrenheit";
        public static string KELVIN { get; } = "Kelvin";

        public TemperatureConversion()
        {
            UnitDict.Add(CELSIUS, typeof(ConvertFromCelsius));
            UnitDict.Add(FAHRENHEIT, typeof(ConvertFromFahrenheit));
            UnitDict.Add(KELVIN, typeof(ConvertFromKelvin));
        }

        /// <summary>
        /// Method to convert value of one unit to other.
        /// </summary>
        /// <param name="convertFrom">Unit to convert from.</param>
        /// <param name="convertTo">Unit to convert to.</param>
        /// <param name="value">Value to convert.</param>
        /// <returns>Converted unit.</returns>
        public decimal convert(string convertFrom, string convertTo, decimal value)
        {
            IUnitConversion temperatureConversion = (IUnitConversion)Activator.CreateInstance(UnitDict[convertFrom])!;

            return temperatureConversion.convert(convertTo, value);
        }
    }
}
