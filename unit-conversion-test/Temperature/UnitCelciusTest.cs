using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Temperature;

namespace unit_conversion_test.Temperature
{
    public class UnitCelciusTest
    {
        [Fact]
        public void ConvertToKelvin()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toKelvin = temp.convert(TemperatureConversion.CELSIUS, TemperatureConversion.KELVIN, 5);

            // Assert
            Assert.Equal(278.15m, toKelvin);
        }

        [Fact]
        public void ConvertToFahrenheit()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toFahrenheit = temp.convert(TemperatureConversion.CELSIUS, TemperatureConversion.FAHRENHEIT, 5);

            // Assert
            Assert.Equal(41m, toFahrenheit);
        }

        [Fact]
        public void ConvertToCelsius()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toFahrenheit = temp.convert(TemperatureConversion.CELSIUS, TemperatureConversion.CELSIUS, 5);

            // Assert
            Assert.Equal(5m, toFahrenheit);
        }
    }
}
