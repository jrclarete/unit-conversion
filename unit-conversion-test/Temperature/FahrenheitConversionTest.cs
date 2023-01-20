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
            UnitOfTemperature temp = new UnitOfTemperature();

            // Act
            decimal toKelvin = temp.convert(UnitOfTemperature.FAHRENHEIT, UnitOfTemperature.KELVIN, 5);

            // Assert
            Assert.Equal(258.15m, toKelvin);
        }

        [Fact]
        public void ConvertToCelsius()
        {
            // Arrange
            UnitOfTemperature temp = new UnitOfTemperature();

            // Act
            decimal toCelcius = temp.convert(UnitOfTemperature.FAHRENHEIT, UnitOfTemperature.CELSIUS, 5);

            // Assert
            Assert.Equal(-15m, toCelcius);
        }

        [Fact]
        public void ConvertToFahrenheit()
        {
            // Arrange
            UnitOfTemperature temp = new UnitOfTemperature();

            // Act
            decimal toFahrenheit = temp.convert(UnitOfTemperature.FAHRENHEIT, UnitOfTemperature.FAHRENHEIT, 5);

            // Assert
            Assert.Equal(5m, toFahrenheit);
        }
    }
}
