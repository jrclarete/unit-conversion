using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;

namespace unit_conversion.Conversions.Length
{
    internal class CentimeterConversion : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodDict = new Dictionary<string, Func<decimal, decimal>>();

        public CentimeterConversion()
        {
            MethodDict.Add(UnitOfLength.MILLIMETER, (value) => ConvertToMillimeter(value));
            MethodDict.Add(UnitOfLength.METER, (value) => ConvertToMeter(value));
            MethodDict.Add(UnitOfLength.KILOMETER, (value) => ConvertToKilometer(value));
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
            return value * 10m;
        }

        private decimal ConvertToMeter(decimal value)
        {
            return value / 100m;
        }

        private decimal ConvertToKilometer(decimal value)
        {
            return value / 100000m;
        }

        private decimal ConvertToInch(decimal value)
        {
            return value / 2.54m;
        }

        private decimal ConvertToFoot(decimal value)
        {
            return value / 30.48m;
        }

        private decimal ConvertToYard(decimal value)
        {
            return value / 91.44m;
        }
    }
}
