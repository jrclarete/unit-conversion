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
            MethodDict.Add(LengthConversion.MILLIMETER, (value) => { ConvertFromMeter instance = new ConvertFromMeter(); return instance.ConvertToMillimeter(value); });
            MethodDict.Add(LengthConversion.CENTIMETER, (value) => { ConvertFromMeter instance = new ConvertFromMeter(); return instance.ConvertToCentimeter(value); });
            MethodDict.Add(LengthConversion.KILOMETER, (value) => { ConvertFromMeter instance = new ConvertFromMeter(); return instance.ConvertToKilometer(value); });
            MethodDict.Add(LengthConversion.INCH, (value) => { ConvertFromMeter instance = new ConvertFromMeter(); return instance.ConvertToInch(value); });
            MethodDict.Add(LengthConversion.FOOT, (value) => { ConvertFromMeter instance = new ConvertFromMeter(); return instance.ConvertToFoot(value); });
            MethodDict.Add(LengthConversion.YARD, (value) => { ConvertFromMeter instance = new ConvertFromMeter(); return instance.ConvertToYard(value); });
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

        private decimal ConvertToInch(decimal value)
        {
            return value / 0.0254m;
        }

        private decimal ConvertToFoot(decimal value)
        {
            return value / 0.3048m;
        }

        private decimal ConvertToYard(decimal value)
        {
            return value / 0.9144m;
        }
    }
}
