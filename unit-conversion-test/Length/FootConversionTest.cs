using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Enums;
using unit_conversion;

namespace unit_conversion_test.Length
{
    public class FootConversionTest
    {
        [Fact]
        public void ConvertToMillimeter()
        {
            // Act
            decimal toMillimeter = LengthConversion.convert(LengthUnit.FOOT, LengthUnit.MILLIMETER, 5);

            // Assert
            Assert.Equal(1524m, toMillimeter);
        }

        [Fact]
        public void ConvertToCentimeter()
        {
            // Act
            decimal toCentimeter = LengthConversion.convert(LengthUnit.FOOT, LengthUnit.CENTIMETER, 5);

            // Assert
            Assert.Equal(152.4m, toCentimeter);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Act
            decimal toMeter = LengthConversion.convert(LengthUnit.FOOT, LengthUnit.METER, 5);

            // Assert
            Assert.Equal(1.524m, toMeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Act
            decimal toKilometer = LengthConversion.convert(LengthUnit.FOOT, LengthUnit.KILOMETER, 5);

            // Assert
            Assert.Equal(0.001524m, toKilometer);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Act
            decimal toInch = LengthConversion.convert(LengthUnit.FOOT, LengthUnit.INCH, 5);

            // Assert
            Assert.Equal(60m, toInch);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Act
            decimal toYard = LengthConversion.convert(LengthUnit.FOOT, LengthUnit.YARD, 5);

            // Assert
            Assert.Equal(1.6666666666666666666666666667m, toYard);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Act
            decimal toFoot = LengthConversion.convert(LengthUnit.FOOT, LengthUnit.FOOT, 5);

            // Assert
            Assert.Equal(5m, toFoot);
        }
    }
}
