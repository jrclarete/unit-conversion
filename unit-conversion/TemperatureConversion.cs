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
        private Dictionary<TemperatureUnit, Type> UnitDict = new Dictionary<TemperatureUnit, Type>();

        public TemperatureConversion()
        {
            UnitDict.Add(TemperatureUnit.CELSIUS, typeof(CelsiusConversion));
            UnitDict.Add(TemperatureUnit.FAHRENHEIT, typeof(FahrenheitConversion));
            UnitDict.Add(TemperatureUnit.KELVIN, typeof(KelvinConversion));
        }

        /// <summary>
        /// Method to convert value of one unit to other.
        /// </summary>
        /// <param name="convertFrom">Unit to convert from.</param>
        /// <param name="convertTo">Unit to convert to.</param>
        /// <param name="value">Value to convert.</param>
        /// <returns>Converted unit.</returns>
        public decimal convert(TemperatureUnit convertFrom, TemperatureUnit convertTo, decimal value)
        {
            decimal convertedValue = 0m;

            try
            {
                IUnitConversion<TemperatureUnit> temperatureConversion = (IUnitConversion<TemperatureUnit>)Activator.CreateInstance(UnitDict[convertFrom])!;
                convertedValue = temperatureConversion.convert(convertTo, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return convertedValue;
        }
    }
}
