using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Length;

namespace unit_conversion_test.Length
{
    public class UnitMeterTest
    {
        [Fact]
        public void ConvertToCentimeter()
        {
            // Arrange
            LengthConversion temp = new LengthConversion();

            // Act
            decimal toCentimeter = temp.convert(LengthConversion.METER, LengthConversion.CENTIMETER, 5);

            // Assert
            Assert.Equal(500m, toCentimeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Arrange
            LengthConversion temp = new LengthConversion();

            // Act
            decimal toKilometer = temp.convert(LengthConversion.METER, LengthConversion.KILOMETER, 5);

            // Assert
            Assert.Equal(0.005m, toKilometer);
        }

        [Fact]
        public void ConvertToMillimeter()
        {
            // Arrange
            LengthConversion temp = new LengthConversion();

            // Act
            decimal toMillimeter = temp.convert(LengthConversion.METER, LengthConversion.MILLIMETER, 5);

            // Assert
            Assert.Equal(5000m, toMillimeter);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Arrange
            LengthConversion temp = new LengthConversion();

            // Act
            decimal toMeter = temp.convert(LengthConversion.METER, LengthConversion.METER, 5);

            // Assert
            Assert.Equal(5m, toMeter);
        }
    }
}
