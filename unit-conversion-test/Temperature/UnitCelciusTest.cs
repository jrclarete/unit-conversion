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
        public void CelciusToKelvin()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toKelvin = temp.convert(TemperatureConversion.Celcius, TemperatureConversion.Kelvin, 5);

            // Assert
            Assert.Equal(278.15m, toKelvin);
        }

        [Fact]
        public void CelciusToFahrenheit()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toFahrenheit = temp.convert(TemperatureConversion.Celcius, TemperatureConversion.Fahrenheit, 5);

            // Assert
            Assert.Equal(41m, toFahrenheit);
        }

        [Fact]
        public void CelciusToCelcius()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toFahrenheit = temp.convert(TemperatureConversion.Celcius, TemperatureConversion.Celcius, 5);

            // Assert
            Assert.Equal(5m, toFahrenheit);
        }
    }
}
