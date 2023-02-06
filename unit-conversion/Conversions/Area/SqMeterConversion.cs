using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Enums;

namespace unit_conversion.Conversions.Area
{
    internal class SqMeterConversion
    {
        private static Dictionary<AreaUnit, Func<decimal, decimal>> MethodDict = new Dictionary<AreaUnit, Func<decimal, decimal>>()
        {
            { AreaUnit.SQMILLIMETER, (value) => ConvertToSqMillimeter(value) },
            { AreaUnit.SQCENTIMETER, (value) => ConvertToSqCentimeter(value) },
        };

        public static decimal convert(AreaUnit convertTo, decimal value)
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

        private static decimal ConvertToSqMillimeter(decimal value)
        {
            return value * 1000000m;
        }

        private static decimal ConvertToSqCentimeter(decimal value)
        {
            return value * 10000m;
        }
    }
}
