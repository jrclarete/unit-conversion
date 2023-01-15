using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Temperature;

namespace unit_conversion_test.Temperature
{
    public class UnitFahrenheitTest
    {
        [Fact]
        public void ConvertToKelvin()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toKelvin = temp.convert(TemperatureConversion.Fahrenheit, TemperatureConversion.Kelvin, 5);

            // Assert
            Assert.Equal(258.15m, toKelvin);
        }

        [Fact]
        public void ConvertToCelcius()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toCelcius = temp.convert(TemperatureConversion.Fahrenheit, TemperatureConversion.Celcius, 5);

            // Assert
            Assert.Equal(-15m, toCelcius);
        }

        [Fact]
        public void ConvertToFahrenheit()
        {
            // Arrange
            TemperatureConversion temp = new TemperatureConversion();

            // Act
            decimal toFahrenheit = temp.convert(TemperatureConversion.Fahrenheit, TemperatureConversion.Fahrenheit, 5);

            // Assert
            Assert.Equal(5m, toFahrenheit);
        }
    }
}
