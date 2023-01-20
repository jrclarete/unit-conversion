using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;

namespace unit_conversion.Conversions.Temperature
{
    internal class FahrenheitConversion : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodDict = new Dictionary<string, Func<decimal, decimal>>();

        public FahrenheitConversion()
        {
            MethodDict.Add(UnitOfTemperature.KELVIN, (value) => ConvertToKelvin(value));
            MethodDict.Add(UnitOfTemperature.CELSIUS, (value) => ConvertToCelsius(value));
        }

        public decimal convert(string convertTo, decimal value)
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

        private decimal ConvertToKelvin(decimal value)
        {
            return (value - 32m) * 5m / 9m + 273.15m;
        }

        private decimal ConvertToCelsius(decimal value)
        {
            return (value - 32m) * 5m / 9m;
        }
    }
}
