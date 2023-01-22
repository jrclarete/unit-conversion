using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;
using unit_conversion.Enums;

namespace unit_conversion.Conversions.Temperature
{
    internal class KelvinConversion : IUnitConversion<TemperatureUnit>
    {
        private Dictionary<TemperatureUnit, Func<decimal, decimal>> MethodDict = new Dictionary<TemperatureUnit, Func<decimal, decimal>>();

        public KelvinConversion()
        {
            MethodDict.Add(TemperatureUnit.CELSIUS, (value) => ConvertToCelsius(value));
            MethodDict.Add(TemperatureUnit.FAHRENHEIT, (value) => ConvertToFahrenheit(value));
        }

        public decimal convert(TemperatureUnit convertTo, decimal value)
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

        private decimal ConvertToCelsius(decimal value)
        {
            return value - 273.15m;
        }

        private decimal ConvertToFahrenheit(decimal value)
        {
            return value * 9m / 5m - 459.67m;
        }
    }
}
