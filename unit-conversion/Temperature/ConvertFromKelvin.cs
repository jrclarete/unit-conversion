using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Temperature
{
    internal class ConvertFromKelvin : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodDict = new Dictionary<string, Func<decimal, decimal>>();

        private void initMethodList()
        {
            MethodDict.Add(TemperatureConversion.CELSIUS, (value) => { ConvertFromKelvin instance = new ConvertFromKelvin(); return instance.ConvertToCelsius(value); });
            MethodDict.Add(TemperatureConversion.FAHRENHEIT, (value) => { ConvertFromKelvin instance = new ConvertFromKelvin(); return instance.ConvertToFahrenheit(value); });
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

        private decimal ConvertToCelsius(decimal value)
        {
            return value - 273.15m;
        }

        private decimal ConvertToFahrenheit(decimal value)
        {
            return (((value * 9m) / 5m) - 459.67m);
        }
    }
}
