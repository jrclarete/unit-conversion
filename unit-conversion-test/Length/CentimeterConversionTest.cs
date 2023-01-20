using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;

namespace unit_conversion_test.Length
{
    public class CentimeterConversionTest
    {
        [Fact]
        public void ConvertToMillimeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toMillimeter = length.convert(UnitOfLength.CENTIMETER, UnitOfLength.MILLIMETER, 5);

            // Assert
            Assert.Equal(50m, toMillimeter);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toMeter = length.convert(UnitOfLength.CENTIMETER, UnitOfLength.METER, 5);

            // Assert
            Assert.Equal(0.05m, toMeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toKilometer = length.convert(UnitOfLength.CENTIMETER, UnitOfLength.KILOMETER, 5);

            // Assert
            Assert.Equal(0.00005m, toKilometer);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toInch = length.convert(UnitOfLength.CENTIMETER, UnitOfLength.INCH, 5);

            // Assert
            Assert.Equal(1.9685039370078740157480314961m, toInch);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toFoot = length.convert(UnitOfLength.CENTIMETER, UnitOfLength.FOOT, 5);

            // Assert
            Assert.Equal(0.1640419947506561679790026247m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toYard = length.convert(UnitOfLength.CENTIMETER, UnitOfLength.YARD, 5);

            // Assert
            Assert.Equal(0.0546806649168853893263342082m, toYard);
        }

        [Fact]
        public void ConvertToCentimeter()
        {
            // Arrange
            UnitOfLength length = new UnitOfLength();

            // Act
            decimal toCentimeter = length.convert(UnitOfLength.CENTIMETER, UnitOfLength.CENTIMETER, 5);

            // Assert
            Assert.Equal(5m, toCentimeter);
        }
    }
}
