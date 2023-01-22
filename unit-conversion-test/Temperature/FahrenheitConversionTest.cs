using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;

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
            decimal toKelvin = temp.convert(TemperatureConversion.FAHRENHEIT, TemperatureConversion.KELVIN, 5);

            // Assert
            Assert.Equal(258.15m, toKelvin);
        }

        [Fact]
        public void ConvertToCelsius()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toCelcius = temp.convert(TemperatureConversion.FAHRENHEIT, TemperatureConversion.CELSIUS, 5);

            // Assert
            Assert.Equal(-15m, toCelcius);
        }

        [Fact]
        public void ConvertToFahrenheit()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toFahrenheit = temp.convert(TemperatureConversion.FAHRENHEIT, TemperatureConversion.FAHRENHEIT, 5);

            // Assert
            Assert.Equal(5m, toFahrenheit);
        }
    }
}
