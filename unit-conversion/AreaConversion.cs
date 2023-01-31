using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions.Area;
using unit_conversion.Conversions.Length;
using unit_conversion.Enums;

namespace unit_conversion
{
    public class AreaConversion
    {
        private static Dictionary<AreaUnit, Func<AreaUnit, decimal, decimal>> UnitDict = new Dictionary<AreaUnit, Func<AreaUnit, decimal, decimal>>()
        {
            { AreaUnit.SQUAREMILLIMETER, (convertTo, value) => SquareMillimeterConversion.convert(convertTo, value) },
        };

        /// <summary>
        /// Method to convert value of one unit to other.
        /// </summary>
        /// <param name="convertFrom">Unit to convert from.</param>
        /// <param name="convertTo">Unit to convert to.</param>
        /// <param name="value">Value to convert.</param>
        /// <returns>Converted unit.</returns>
        public static decimal convert(AreaUnit convertFrom, AreaUnit convertTo, decimal value)
        {
            decimal convertedValue = 0m;

            try
            {
                convertedValue = UnitDict[convertFrom](convertTo, value);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

            return convertedValue;
        }
    }
}
