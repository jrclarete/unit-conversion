using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;
using unit_conversion.Enums;

namespace unit_conversion.Conversions.Temperature
{
    internal class KelvinConversion
    {
        private static Dictionary<TemperatureUnit, Func<decimal, decimal>> MethodDict = new Dictionary<TemperatureUnit, Func<decimal, decimal>>()
        {
            { TemperatureUnit.CELSIUS, (value) => ConvertToCelsius(value) },
            { TemperatureUnit.FAHRENHEIT, (value) => ConvertToFahrenheit(value) }
        };

        public static decimal convert(TemperatureUnit convertTo, decimal value)
        {
            decimal convertedValue = 0m;

            if (MethodDict.ContainsKey(convertTo))
            {
                convertedValue = MethodDict[convertTo](value);
            }
            else
            {
                convertedValue = value;
            }

            return convertedValue;
        }

        private static decimal ConvertToCelsius(decimal value)
        {
            return value - 273.15m;
        }

        private static decimal ConvertToFahrenheit(decimal value)
        {
            return value * 9m / 5m - 459.67m;
        }
    }
}
