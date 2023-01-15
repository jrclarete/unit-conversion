using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Temperature
{
    internal class ConvertFromFahrenheit : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodList = new Dictionary<string, Func<decimal, decimal>>();

        private void initMethodList()
        {
            MethodList.Add(TemperatureConversion.Kelvin, (value) => { ConvertFromFahrenheit instance = new ConvertFromFahrenheit(); return instance.ConvertToKelvin(value); });
            MethodList.Add(TemperatureConversion.Celcius, (value) => { ConvertFromFahrenheit instance = new ConvertFromFahrenheit(); return instance.ConvertToCelcius(value); });
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
            return (((value - 32m) * 5m) / 9m) + 273.15m;
        }

        private decimal ConvertToCelcius(decimal value)
        {
            return (((value - 32m) * 5m) / 9m);
        }
    }
}
