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
            { AreaUnit.SQFOOT, (value) => ConvertToSqFoot(value) },
            { AreaUnit.SQYARD, (value) => ConvertToSqYard(value) },
            { AreaUnit.SQMILE, (value) => ConvertToSqMile(value) },
            { AreaUnit.HECTARE, (value) => ConvertToHectare(value) },
            { AreaUnit.ACRE, (value) => ConvertToAcre(value) },
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

        private static decimal ConvertToSqFoot(decimal value)
        {
            return value / 929.0304m;
        }

        private static decimal ConvertToSqYard(decimal value)
        {
            return value / 8361.2736m;
        }

        private static decimal ConvertToSqMile(decimal value)
        {
            return value / 25899900000m;
        }

        private static decimal ConvertToHectare(decimal value)
        {
            return value / 100000000m;
        }

        private static decimal ConvertToAcre(decimal value)
        {
            decimal sqInch = value / 6.4516m;
            return sqInch / 6272640m;
        }
    }
}
