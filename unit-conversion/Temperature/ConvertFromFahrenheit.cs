﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Temperature
{
    internal class ConvertFromFahrenheit : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodDict = new Dictionary<string, Func<decimal, decimal>>();

        private void initMethodList()
        {
            MethodDict.Add(TemperatureConversion.KELVIN, (value) => { ConvertFromFahrenheit instance = new ConvertFromFahrenheit(); return instance.ConvertToKelvin(value); });
            MethodDict.Add(TemperatureConversion.CELSIUS, (value) => { ConvertFromFahrenheit instance = new ConvertFromFahrenheit(); return instance.ConvertToCelsius(value); });
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
            return (((value - 32m) * 5m) / 9m) + 273.15m;
        }

        private decimal ConvertToCelsius(decimal value)
        {
            return (((value - 32m) * 5m) / 9m);
        }
    }
}