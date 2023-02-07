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
            { AreaUnit.SQKILOMETER, (value) => ConvertToSqKilometer(value) },
            { AreaUnit.SQINCH, (value) => ConvertToSqInch(value) },
            { AreaUnit.SQFOOT, (value) => ConvertToSqFoot(value) },
            { AreaUnit.SQYARD, (value) => ConvertToSqYard(value) },
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

        private static decimal ConvertToSqKilometer(decimal value)
        {
            return value * 0.000001m;
        }

        private static decimal ConvertToSqInch(decimal value)
        {
            return value * 1550.0031m;
        }

        private static decimal ConvertToSqFoot(decimal value)
        {
            decimal sqCentimeter = value * 10000m;
            return sqCentimeter / 929.0304m;
        }

        private static decimal ConvertToSqYard(decimal value)
        {
            decimal sqCentimeter = value * 10000m;
            return sqCentimeter / 8361.2736m;
        }
    }
}
