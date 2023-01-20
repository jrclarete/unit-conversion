using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;

namespace unit_conversion_test.Length
{
    public class MillimeterConversionTest
    {
        [Fact]
        public void ConvertToCentimeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toCentimeter = length.convert(UnitOfLength.MILLIMETER, UnitOfLength.CENTIMETER, 5);

            // Assert
            Assert.Equal(0.5m, toCentimeter);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toMeter = length.convert(UnitOfLength.MILLIMETER, UnitOfLength.METER, 5);

            // Assert
            Assert.Equal(0.005m, toMeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toKilometer = length.convert(UnitOfLength.MILLIMETER, UnitOfLength.KILOMETER, 5);

            // Assert
            Assert.Equal(0.000005m, toKilometer);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toInch = length.convert(UnitOfLength.MILLIMETER, UnitOfLength.INCH, 5);

            // Assert
            Assert.Equal(0.1968503937007874015748031496m, toInch);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toFoot = length.convert(UnitOfLength.MILLIMETER, UnitOfLength.FOOT, 5);

            // Assert
            Assert.Equal(0.0164041994750656167979002625m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toYard = length.convert(UnitOfLength.MILLIMETER, UnitOfLength.YARD, 5);

            // Assert
            Assert.Equal(0.0054680664916885389326334208m, toYard);
        }

        [Fact]
        public void ConvertToMillimeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toCentimeter = length.convert(UnitOfLength.MILLIMETER, UnitOfLength.MILLIMETER, 5);

            // Assert
            Assert.Equal(5m, toCentimeter);
        }
    }
}
