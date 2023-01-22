using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;
using unit_conversion.Enums;

namespace unit_conversion_test.Length
{
    public class KilometerConversionTest
    {
        [Fact]
        public void ConvertToMillimeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toMillimeter = length.convert(LengthUnit.KILOMETER, LengthUnit.MILLIMETER, 5);

            // Assert
            Assert.Equal(5000000m, toMillimeter);
        }

        [Fact]
        public void ConvertToCentimeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toCentimeter = length.convert(LengthUnit.KILOMETER, LengthUnit.CENTIMETER, 5);

            // Assert
            Assert.Equal(500000m, toCentimeter);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toMeter = length.convert(LengthUnit.KILOMETER, LengthUnit.METER, 5);

            // Assert
            Assert.Equal(5000m, toMeter);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toInch = length.convert(LengthUnit.KILOMETER, LengthUnit.INCH, 5);

            // Assert
            Assert.Equal(196850.39370078740157480314961m, toInch);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toFoot = length.convert(LengthUnit.KILOMETER, LengthUnit.FOOT, 5);

            // Assert
            Assert.Equal(16404.199475065616797900262467m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toYard = length.convert(LengthUnit.KILOMETER, LengthUnit.YARD, 5);

            // Assert
            Assert.Equal(5468.0664916885389326334208224m, toYard);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toKilometer = length.convert(LengthUnit.KILOMETER, LengthUnit.KILOMETER, 5);

            // Assert
            Assert.Equal(5m, toKilometer);
        }
    }
}
