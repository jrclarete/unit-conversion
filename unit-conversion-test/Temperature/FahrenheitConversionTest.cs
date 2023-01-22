using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;
using unit_conversion.Enums;

namespace unit_conversion_test.Temperature
{
    public class FahrenheitConversionTest
    {
        [Fact]
        public void ConvertToKelvin()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toKelvin = temp.convert(TemperatureUnit.FAHRENHEIT, TemperatureUnit.KELVIN, 5);

            // Assert
            Assert.Equal(258.15m, toKelvin);
        }

        [Fact]
        public void ConvertToCelsius()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toCelcius = temp.convert(TemperatureUnit.FAHRENHEIT, TemperatureUnit.CELSIUS, 5);

            // Assert
            Assert.Equal(-15m, toCelcius);
        }

        [Fact]
        public void ConvertToFahrenheit()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toFahrenheit = temp.convert(TemperatureUnit.FAHRENHEIT, TemperatureUnit.FAHRENHEIT, 5);

            // Assert
            Assert.Equal(5m, toFahrenheit);
        }
    }
}
