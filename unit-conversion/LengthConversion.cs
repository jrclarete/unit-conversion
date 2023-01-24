using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;
using unit_conversion.Conversions.Length;
using unit_conversion.Enums;

namespace unit_conversion
{
    public class LengthConversion
    {
        private Dictionary<LengthUnit, Type> UnitDict = new Dictionary<LengthUnit, Type>();

        public LengthConversion()
        {
            UnitDict.Add(LengthUnit.MILLIMETER, typeof(MillimeterConversion));
            UnitDict.Add(LengthUnit.CENTIMETER, typeof(CentimeterConversion));
            UnitDict.Add(LengthUnit.METER, typeof(MeterConversion));
            UnitDict.Add(LengthUnit.KILOMETER, typeof(KilometerConversion));
            UnitDict.Add(LengthUnit.INCH, typeof(InchConversion));
            UnitDict.Add(LengthUnit.FOOT, typeof(FootConversion));
        }

        /// <summary>
        /// Method to convert value of one unit to other.
        /// </summary>
        /// <param name="convertFrom">Unit to convert from.</param>
        /// <param name="convertTo">Unit to convert to.</param>
        /// <param name="value">Value to convert.</param>
        /// <returns>Converted unit.</returns>
        public decimal convert(LengthUnit convertFrom, LengthUnit convertTo, decimal value)
        {
            decimal convertedValue = 0m;

            try
            {
                IUnitConversion<LengthUnit> lengthConversion = (IUnitConversion<LengthUnit>)Activator.CreateInstance(UnitDict[convertFrom])!;
                convertedValue = lengthConversion.convert(convertTo, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return convertedValue;
        }
    }
}
