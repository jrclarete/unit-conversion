using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;
using unit_conversion.Enums;

namespace unit_conversion.Conversions.Temperature
{
    internal class CelsiusConversion
    {
        private static Dictionary<TemperatureUnit, Func<decimal, decimal>> MethodDict = new Dictionary<TemperatureUnit, Func<decimal, decimal>>()
        {
            //MethodDict.Add(UnitOfTemperature.KELVIN, (value) => { CelsiusConversion instance = new CelsiusConversion(); return instance.ConvertToKelvin(value); });
            { TemperatureUnit.KELVIN, (value) => ConvertToKelvin(value) },
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

        private static decimal ConvertToKelvin(decimal value)
        {
            return value + 273.15m;
        }

        private static decimal ConvertToFahrenheit(decimal value)
        {
            return value * 1.8m + 32m;
        }
    }
}
