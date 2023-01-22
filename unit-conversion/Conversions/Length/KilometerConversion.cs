using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Enums;

namespace unit_conversion.Conversions.Length
{
    internal class KilometerConversion : IUnitConversion<LengthUnit>
    {
        private Dictionary<LengthUnit, Func<decimal, decimal>> MethodDict = new Dictionary<LengthUnit, Func<decimal, decimal>>();

        public KilometerConversion()
        {
            MethodDict.Add(LengthUnit.MILLIMETER, (value) => ConvertToMillimeter(value));
            MethodDict.Add(LengthUnit.CENTIMETER, (value) => ConvertToCentimeter(value));
            MethodDict.Add(LengthUnit.METER, (value) => ConvertToMeter(value));
            MethodDict.Add(LengthUnit.INCH, (value) => ConvertToInch(value));
            MethodDict.Add(LengthUnit.FOOT, (value) => ConvertToFoot(value));
            MethodDict.Add(LengthUnit.YARD, (value) => ConvertToYard(value));
        }

        public decimal convert(LengthUnit convertTo, decimal value)
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
