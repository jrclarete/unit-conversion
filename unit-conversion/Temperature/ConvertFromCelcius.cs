using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Temperature
{
    internal class ConvertFromCelcius : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodList = new Dictionary<string, Func<decimal, decimal>>();

        private void initMethodList()
        {
            MethodList.Add(TemperatureConversion.Kelvin, (value) => { ConvertFromCelcius instance = new ConvertFromCelcius(); return instance.ConvertToKelvin(value); });
            MethodList.Add(TemperatureConversion.Fahrenheit, (value) => { ConvertFromCelcius instance = new ConvertFromCelcius(); return instance.ConvertToFahrenheit(value); });
        }
        public decimal convert(string convertTo, decimal value)
        {
            initMethodList();

            decimal convertedValue = 0m;

            if (MethodList.ContainsKey(convertTo)) 
            {
                convertedValue = MethodList[convertTo](value);
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
