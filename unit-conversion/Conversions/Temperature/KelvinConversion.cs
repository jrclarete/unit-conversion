using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;

namespace unit_conversion.Conversions.Temperature
{
    internal class KelvinConversion : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodDict = new Dictionary<string, Func<decimal, decimal>>();

        private void initMethodDict()
        {
            MethodDict.Add(UnitOfTemperature.CELSIUS, (value) => { KelvinConversion instance = new KelvinConversion(); return instance.ConvertToCelsius(value); });
            MethodDict.Add(UnitOfTemperature.FAHRENHEIT, (value) => { KelvinConversion instance = new KelvinConversion(); return instance.ConvertToFahrenheit(value); });
        }

        public decimal convert(string convertTo, decimal value)
        {
            initMethodDict();

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
