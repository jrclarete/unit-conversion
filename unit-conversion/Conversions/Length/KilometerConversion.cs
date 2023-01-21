using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Conversions.Length
{
    internal class KilometerConversion : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodDict = new Dictionary<string, Func<decimal, decimal>>();

        public KilometerConversion()
        {
            MethodDict.Add(UnitOfLength.MILLIMETER, (value) => ConvertToMillimeter(value));
            MethodDict.Add(UnitOfLength.CENTIMETER, (value) => ConvertToCentimeter(value));
            MethodDict.Add(UnitOfLength.METER, (value) => ConvertToMeter(value));
            MethodDict.Add(UnitOfLength.INCH, (value) => ConvertToInch(value));
            MethodDict.Add(UnitOfLength.FOOT, (value) => ConvertToFoot(value));
            MethodDict.Add(UnitOfLength.YARD, (value) => ConvertToYard(value));
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

        private decimal ConvertToMillimeter(decimal value)
        {
            return value * 1000000m;
        }

        private decimal ConvertToCentimeter(decimal value)
        {
            return value * 100000m;
        }

        private decimal ConvertToMeter(decimal value)
        {
            return value * 1000m;
        }

        private decimal ConvertToInch(decimal value)
        {
            return value / 0.0000254m;
        }

        private decimal ConvertToFoot(decimal value)
        {
            return value / 0.0003048m;
        }

        private decimal ConvertToYard(decimal value)
        {
            return value / 0.0009144m;
        }
    }
}
