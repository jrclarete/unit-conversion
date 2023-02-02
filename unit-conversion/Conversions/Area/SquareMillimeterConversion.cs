using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Enums;

namespace unit_conversion.Conversions.Area
{
    internal class SquareMillimeterConversion
    {
        private static Dictionary<AreaUnit, Func<decimal, decimal>> MethodDict = new Dictionary<AreaUnit, Func<decimal, decimal>>()
        {
            { AreaUnit.SQCENTIMETER, (value) => ConvertToSqCentimeter(value) },
            { AreaUnit.SQMETER, (value) => ConvertToSqMeter(value) },
            { AreaUnit.SQKILOMETER, (value) => ConvertToSqKilometer(value) },
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

        private static decimal ConvertToSqCentimeter(decimal value)
        {
            return value * 0.01m;
        }

        private static decimal ConvertToSqMeter(decimal value)
        {
            return value * 0.000001m;
        }

        private static decimal ConvertToSqKilometer(decimal value)
        {
            return value / 1000000000000m;
        }
    }
}
