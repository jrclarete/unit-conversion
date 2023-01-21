using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;
using unit_conversion.Conversions.Length;

namespace unit_conversion
{
    public class UnitOfLength
    {
        private Dictionary<string, Type> UnitDict = new Dictionary<string, Type>();

        public static string MILLIMETER { get; } = "Millimeter";
        public static string CENTIMETER { get; } = "Centimeter";
        public static string METER { get; } = "Meter";
        public static string KILOMETER { get; } = "Kilometer";
        public static string INCH { get; } = "Inch";
        public static string FOOT { get; } = "Foot";
        public static string YARD { get; } = "Yard";

        public UnitOfLength()
        {
            UnitDict.Add(MILLIMETER, typeof(MillimeterConversion));
            UnitDict.Add(CENTIMETER, typeof(CentimeterConversion));
            UnitDict.Add(METER, typeof(MeterConversion));
            UnitDict.Add(KILOMETER, typeof(KilometerConversion));
        }

        /// <summary>
        /// Method to convert value of one unit to other.
        /// </summary>
        /// <param name="convertFrom">Unit to convert from.</param>
        /// <param name="convertTo">Unit to convert to.</param>
        /// <param name="value">Value to convert.</param>
        /// <returns>Converted unit.</returns>
        public decimal convert(string convertFrom, string convertTo, decimal value)
        {
            IUnitConversion lengthConversion = (IUnitConversion)Activator.CreateInstance(UnitDict[convertFrom])!;

            return lengthConversion.convert(convertTo, value);
        }
    }
}
