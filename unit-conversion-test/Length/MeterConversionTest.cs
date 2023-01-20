using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;

namespace unit_conversion_test.Length
{
    public class MeterConversionTest
    {
        [Fact]
        public void ConvertToCentimeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toCentimeter = length.convert(UnitOfLength.METER, UnitOfLength.CENTIMETER, 5);

            // Assert
            Assert.Equal(500m, toCentimeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toKilometer = length.convert(UnitOfLength.METER, UnitOfLength.KILOMETER, 5);

            // Assert
            Assert.Equal(0.005m, toKilometer);
        }

        [Fact]
        public void ConvertToMillimeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toMillimeter = length.convert(UnitOfLength.METER, UnitOfLength.MILLIMETER, 5);

            // Assert
            Assert.Equal(5000m, toMillimeter);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toInch = length.convert(UnitOfLength.METER, UnitOfLength.INCH, 5);

            // Assert
            Assert.Equal(196.85039370078740157480314961m, toInch);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toFoot = length.convert(UnitOfLength.METER, UnitOfLength.FOOT, 5);

            // Assert
            Assert.Equal(16.404199475065616797900262467m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toYard = length.convert(UnitOfLength.METER, UnitOfLength.YARD, 5);

            // Assert
            Assert.Equal(5.4680664916885389326334208224m, toYard);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toMeter = length.convert(UnitOfLength.METER, UnitOfLength.METER, 5);

            // Assert
            Assert.Equal(5m, toMeter);
        }
    }
}
