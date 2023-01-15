using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Temperature;

namespace unit_conversion.Length
{
    internal class ConvertFromMeter : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodDict = new Dictionary<string, Func<decimal, decimal>>();

        private void initMethodList()
        {
            MethodDict.Add(LengthConversion.CENTIMETER, (value) => { ConvertFromMeter instance = new ConvertFromMeter(); return instance.ConvertToCentimeter(value); });
            MethodDict.Add(LengthConversion.KILOMETER, (value) => { ConvertFromMeter instance = new ConvertFromMeter(); return instance.ConvertToKilometer(value); });
            MethodDict.Add(LengthConversion.MILLIMETER, (value) => { ConvertFromMeter instance = new ConvertFromMeter(); return instance.ConvertToMillimeter(value); });
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

        private decimal ConvertToMillimeter(decimal value)
        {
            return value * 1000m;
        }

        private decimal ConvertToCentimeter(decimal value)
        {
            return value * 100m;
        }

        private decimal ConvertToKilometer(decimal value)
        {
            return value / 1000m;
        }
    }
}
