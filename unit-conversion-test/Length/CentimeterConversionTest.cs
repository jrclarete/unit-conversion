using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;
using unit_conversion.Enums;

namespace unit_conversion_test.Length
{
    public class CentimeterConversionTest
    {
        [Fact]
        public void ConvertToMillimeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toMillimeter = length.convert(LengthUnit.CENTIMETER, LengthUnit.MILLIMETER, 5);

            // Assert
            Assert.Equal(50m, toMillimeter);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toMeter = length.convert(LengthUnit.CENTIMETER, LengthUnit.METER, 5);

            // Assert
            Assert.Equal(0.05m, toMeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toKilometer = length.convert(LengthUnit.CENTIMETER, LengthUnit.KILOMETER, 5);

            // Assert
            Assert.Equal(0.00005m, toKilometer);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toInch = length.convert(LengthUnit.CENTIMETER, LengthUnit.INCH, 5);

            // Assert
            Assert.Equal(1.9685039370078740157480314961m, toInch);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toFoot = length.convert(LengthUnit.CENTIMETER, LengthUnit.FOOT, 5);

            // Assert
            Assert.Equal(0.1640419947506561679790026247m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toYard = length.convert(LengthUnit.CENTIMETER, LengthUnit.YARD, 5);

            // Assert
            Assert.Equal(0.0546806649168853893263342082m, toYard);
        }

        [Fact]
        public void ConvertToCentimeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toCentimeter = length.convert(LengthUnit.CENTIMETER, LengthUnit.CENTIMETER, 5);

            // Assert
            Assert.Equal(5m, toCentimeter);
        }
    }
}
