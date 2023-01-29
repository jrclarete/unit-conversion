using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;
using unit_conversion.Enums;

namespace unit_conversion.Conversions.Length
{
    internal class CentimeterConversion
    {
        private static Dictionary<LengthUnit, Func<decimal, decimal>> MethodDict = new Dictionary<LengthUnit, Func<decimal, decimal>>()
        {
            { LengthUnit.MILLIMETER, (value) => ConvertToMillimeter(value) },
            { LengthUnit.METER, (value) => ConvertToMeter(value) },
            { LengthUnit.KILOMETER, (value) => ConvertToKilometer(value) },
            { LengthUnit.INCH, (value) => ConvertToInch(value) },
            { LengthUnit.FOOT, (value) => ConvertToFoot(value) },
            { LengthUnit.YARD, (value) => ConvertToYard(value) }
        };

        public static decimal convert(LengthUnit convertTo, decimal value)
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

        private static decimal ConvertToMillimeter(decimal value)
        {
            return value * 10m;
        }

        private static decimal ConvertToMeter(decimal value)
        {
            return value / 100m;
        }

        private static decimal ConvertToKilometer(decimal value)
        {
            return value / 100000m;
        }

        private static decimal ConvertToInch(decimal value)
        {
            return value / 2.54m;
        }

        private static decimal ConvertToFoot(decimal value)
        {
            return value / 30.48m;
        }

        private static decimal ConvertToYard(decimal value)
        {
            return value / 91.44m;
        }
    }
}
