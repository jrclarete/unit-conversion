using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Enums;

namespace unit_conversion.Conversions.Area
{
    internal class SqCentimeterConversion
    {
        private static Dictionary<AreaUnit, Func<decimal, decimal>> MethodDict = new Dictionary<AreaUnit, Func<decimal, decimal>>()
        {
            { AreaUnit.SQMILLIMETER, (value) => ConvertToSqMillimeter(value) },
            { AreaUnit.SQMETER, (value) => ConvertToSqMeter(value) },
            { AreaUnit.SQKILOMETER, (value) => ConvertToSqKilometer(value) },
            { AreaUnit.SQINCH, (value) => ConvertToSqInch(value) },
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
            return value * 100m;
        }

        private static decimal ConvertToSqMeter(decimal value)
        {
            return value * 0.0001m;
        }

        private static decimal ConvertToSqKilometer(decimal value)
        {
            return value / 10000000000m;
        }

        private static decimal ConvertToSqInch(decimal value)
        {
            return value / 6.4516m;
        }
    }
}
