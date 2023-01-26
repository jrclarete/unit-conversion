using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Conversions;
using unit_conversion.Conversions.Temperature;
using unit_conversion.Enums;

namespace unit_conversion
{
    public class TemperatureConversion
    {
        private static Dictionary<TemperatureUnit, Func<TemperatureUnit, decimal, decimal>> UnitDict = new Dictionary<TemperatureUnit, Func<TemperatureUnit, decimal, decimal>>()
        {
            { TemperatureUnit.CELSIUS, (convertTo, value) => CelsiusConversion.convert(convertTo, value) },
            { TemperatureUnit.FAHRENHEIT, (convertTo, value) => FahrenheitConversion.convert(convertTo, value) },
            { TemperatureUnit.KELVIN, (convertTo, value) => KelvinConversion.convert(convertTo, value) }
        };

        /// <summary>
        /// Method to convert value of one unit to other.
        /// </summary>
        /// <param name="convertFrom">Unit to convert from.</param>
        /// <param name="convertTo">Unit to convert to.</param>
        /// <param name="value">Value to convert.</param>
        /// <returns>Converted unit.</returns>
        public static decimal convert(TemperatureUnit convertFrom, TemperatureUnit convertTo, decimal value)
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
