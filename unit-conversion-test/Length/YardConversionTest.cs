using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Enums;
using unit_conversion;

namespace unit_conversion_test.Length
{
    public class YardConversionTest
    {
        [Fact]
        public void ConvertToMillimeter()
        {
            // Act
            decimal toMillimeter = LengthConversion.convert(LengthUnit.YARD, LengthUnit.MILLIMETER, 5);

            // Assert
            Assert.Equal(4572m, toMillimeter);
        }

        [Fact]
        public void ConvertToCentimeter()
        {
            // Act
            decimal toCentimeter = LengthConversion.convert(LengthUnit.YARD, LengthUnit.CENTIMETER, 5);

            // Assert
            Assert.Equal(457.2m, toCentimeter);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Act
            decimal toMeter = LengthConversion.convert(LengthUnit.YARD, LengthUnit.METER, 5);

            // Assert
            Assert.Equal(4.572m, toMeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Act
            decimal toKilometer = LengthConversion.convert(LengthUnit.YARD, LengthUnit.KILOMETER, 5);

            // Assert
            Assert.Equal(0.004572m, toKilometer);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Act
            decimal toInch = LengthConversion.convert(LengthUnit.YARD, LengthUnit.INCH, 5);

            // Assert
            Assert.Equal(180m, toInch);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Act
            decimal toFoot = LengthConversion.convert(LengthUnit.YARD, LengthUnit.FOOT, 5);

            // Assert
            Assert.Equal(15m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Act
            decimal toYard = LengthConversion.convert(LengthUnit.YARD, LengthUnit.YARD, 5);

            // Assert
            Assert.Equal(5m, toYard);
        }
    }
}
