using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;

namespace unit_conversion.Conversions.Temperature
{
    internal class CelsiusConversion : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodDict = new Dictionary<string, Func<decimal, decimal>>();

        private void initMethodList()
        {
            MethodDict.Add(UnitOfTemperature.KELVIN, (value) => { CelsiusConversion instance = new CelsiusConversion(); return instance.ConvertToKelvin(value); });
            MethodDict.Add(UnitOfTemperature.FAHRENHEIT, (value) => { CelsiusConversion instance = new CelsiusConversion(); return instance.ConvertToFahrenheit(value); });
        }
        public decimal convert(string convertTo, decimal value)
        {
            initMethodList();

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
            return value + 273.15m;
        }

        private decimal ConvertToFahrenheit(decimal value)
        {
            return value * 1.8m + 32m;
        }
    }
}
