using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Temperature
{
    internal class ConvertFromCelsius : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodDict = new Dictionary<string, Func<decimal, decimal>>();

        private void initMethodList()
        {
            MethodDict.Add(TemperatureConversion.KELVIN, (value) => { ConvertFromCelsius instance = new ConvertFromCelsius(); return instance.ConvertToKelvin(value); });
            MethodDict.Add(TemperatureConversion.FAHRENHEIT, (value) => { ConvertFromCelsius instance = new ConvertFromCelsius(); return instance.ConvertToFahrenheit(value); });
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
            return (value * 1.8m) + 32m;
        }
    }
}
