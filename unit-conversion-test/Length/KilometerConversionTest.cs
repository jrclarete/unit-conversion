using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;

namespace unit_conversion_test.Length
{
    public class KilometerConversionTest
    {
        [Fact]
        public void ConvertToMillimeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toMillimeter = length.convert(UnitOfLength.KILOMETER, UnitOfLength.MILLIMETER, 5);

            // Assert
            Assert.Equal(5000000m, toMillimeter);
        }

        [Fact]
        public void ConvertToCentimeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toCentimeter = length.convert(UnitOfLength.KILOMETER, UnitOfLength.CENTIMETER, 5);

            // Assert
            Assert.Equal(500000m, toCentimeter);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toMeter = length.convert(UnitOfLength.KILOMETER, UnitOfLength.METER, 5);

            // Assert
            Assert.Equal(5000m, toMeter);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toInch = length.convert(UnitOfLength.KILOMETER, UnitOfLength.INCH, 5);

            // Assert
            Assert.Equal(196850.39370078740157480314961m, toInch);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toFoot = length.convert(UnitOfLength.KILOMETER, UnitOfLength.FOOT, 5);

            // Assert
            Assert.Equal(16404.199475065616797900262467m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toYard = length.convert(UnitOfLength.KILOMETER, UnitOfLength.YARD, 5);

            // Assert
            Assert.Equal(5468.0664916885389326334208224m, toYard);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toKilometer = length.convert(UnitOfLength.KILOMETER, UnitOfLength.KILOMETER, 5);

            // Assert
            Assert.Equal(5m, toKilometer);
        }
    }
}
