using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;

namespace unit_conversion_test.Temperature
{
    public class CelciusConversionTest
    {
        [Fact]
        public void ConvertToKelvin()
        {
            // Arrange
            UnitOfTemperature temp = new UnitOfTemperature();

            // Act
            decimal toKelvin = temp.convert(UnitOfTemperature.CELSIUS, UnitOfTemperature.KELVIN, 5);

            // Assert
            Assert.Equal(278.15m, toKelvin);
        }

        [Fact]
        public void ConvertToFahrenheit()
        {
            // Arrange
            UnitOfTemperature temp = new UnitOfTemperature();

            // Act
            decimal toFahrenheit = temp.convert(UnitOfTemperature.CELSIUS, UnitOfTemperature.FAHRENHEIT, 5);

            // Assert
            Assert.Equal(41m, toFahrenheit);
        }

        [Fact]
        public void ConvertToCelsius()
        {
            // Arrange
            UnitOfTemperature temp = new UnitOfTemperature();

            // Act
            decimal toFahrenheit = temp.convert(UnitOfTemperature.CELSIUS, UnitOfTemperature.CELSIUS, 5);

            // Assert
            Assert.Equal(5m, toFahrenheit);
        }
    }
}
