using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;
using unit_conversion.Conversions.Length;
using unit_conversion.Conversions.Temperature;
using unit_conversion.Enums;

namespace unit_conversion
{
    public class LengthConversion
    {
        private static Dictionary<LengthUnit, Func<LengthUnit, decimal, decimal>> UnitDict = new Dictionary<LengthUnit, Func<LengthUnit, decimal, decimal>>()
        {
            { LengthUnit.MILLIMETER, (convertTo, value) => MillimeterConversion.convert(convertTo, value) },
            { LengthUnit.CENTIMETER, (convertTo, value) => CentimeterConversion.convert(convertTo, value) },
            { LengthUnit.METER, (convertTo, value) => MeterConversion.convert(convertTo, value) },
            { LengthUnit.KILOMETER, (convertTo, value) => KilometerConversion.convert(convertTo, value) },
            { LengthUnit.INCH, (convertTo, value) => InchConversion.convert(convertTo, value) },
            { LengthUnit.FOOT, (convertTo, value) => FootConversion.convert(convertTo, value) }
        };

        /// <summary>
        /// Method to convert value of one unit to other.
        /// </summary>
        /// <param name="convertFrom">Unit to convert from.</param>
        /// <param name="convertTo">Unit to convert to.</param>
        /// <param name="value">Value to convert.</param>
        /// <returns>Converted unit.</returns>
        public static decimal convert(LengthUnit convertFrom, LengthUnit convertTo, decimal value)
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
