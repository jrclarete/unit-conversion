using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;

namespace unit_conversion_test.Temperature
{
    public class KelvinConversionTest
    {
        [Fact]
        public void ConvertToCelsius()
        {
            // Arrange
            UnitOfTemperature temp = new UnitOfTemperature();

            // Act
            decimal toCelcius = temp.convert(UnitOfTemperature.KELVIN, UnitOfTemperature.CELSIUS, 5);

            // Assert
            Assert.Equal(-268.15m, toCelcius);
        }

        [Fact]
        public void ConvertToFahrenheit()
        {
            // Arrange
            UnitOfTemperature temp = new UnitOfTemperature();

            // Act
            decimal toFahrenheit = temp.convert(UnitOfTemperature.KELVIN, UnitOfTemperature.FAHRENHEIT, 5);

            // Assert
            Assert.Equal(-450.67m, toFahrenheit);
        }

        [Fact]
        public void ConvertToKelvin()
        {
            // Arrange
            UnitOfTemperature temp = new UnitOfTemperature();

            // Act
            decimal toKelvin = temp.convert(UnitOfTemperature.KELVIN, UnitOfTemperature.KELVIN, 5);

            // Assert
            Assert.Equal(5m, toKelvin);
        }
    }
}
