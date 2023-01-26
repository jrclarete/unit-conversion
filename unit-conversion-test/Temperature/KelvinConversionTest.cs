using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;
using unit_conversion.Enums;

namespace unit_conversion_test.Temperature
{
    public class KelvinConversionTest
    {
        [Fact]
        public void ConvertToCelsius()
        {
            // Act
            decimal toCelcius = TemperatureConversion.convert(TemperatureUnit.KELVIN, TemperatureUnit.CELSIUS, 5);

            // Assert
            Assert.Equal(-268.15m, toCelcius);
        }

        [Fact]
        public void ConvertToFahrenheit()
        {
            // Act
            decimal toFahrenheit = TemperatureConversion.convert(TemperatureUnit.KELVIN, TemperatureUnit.FAHRENHEIT, 5);

            // Assert
            Assert.Equal(-450.67m, toFahrenheit);
        }

        [Fact]
        public void ConvertToKelvin()
        {
            // Act
            decimal toKelvin = TemperatureConversion.convert(TemperatureUnit.KELVIN, TemperatureUnit.KELVIN, 5);

            // Assert
            Assert.Equal(5m, toKelvin);
        }
    }
}
