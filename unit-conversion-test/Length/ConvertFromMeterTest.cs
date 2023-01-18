using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Length;

namespace unit_conversion_test.Length
{
    public class ConvertFromMeterTest
    {
        [Fact]
        public void ConvertToCentimeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toCentimeter = length.convert(LengthConversion.METER, LengthConversion.CENTIMETER, 5);

            // Assert
            Assert.Equal(500m, toCentimeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toKilometer = length.convert(LengthConversion.METER, LengthConversion.KILOMETER, 5);

            // Assert
            Assert.Equal(0.005m, toKilometer);
        }

        [Fact]
        public void ConvertToMillimeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toMillimeter = length.convert(LengthConversion.METER, LengthConversion.MILLIMETER, 5);

            // Assert
            Assert.Equal(5000m, toMillimeter);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toInch = length.convert(LengthConversion.METER, LengthConversion.INCH, 5);

            // Assert
            Assert.Equal(196.85039370078740157480314961m, toInch);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toFoot = length.convert(LengthConversion.METER, LengthConversion.FOOT, 5);

            // Assert
            Assert.Equal(16.404199475065616797900262467m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toYard = length.convert(LengthConversion.METER, LengthConversion.YARD, 5);

            // Assert
            Assert.Equal(5.4680664916885389326334208224m, toYard);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toMeter = length.convert(LengthConversion.METER, LengthConversion.METER, 5);

            // Assert
            Assert.Equal(5m, toMeter);
        }
    }
}
