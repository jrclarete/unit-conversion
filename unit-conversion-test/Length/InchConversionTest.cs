using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Enums;
using unit_conversion;

namespace unit_conversion_test.Length
{
    public class InchConversionTest
    {
        [Fact]
        public void ConvertToMillimeter()
        {
            // Act
            decimal toMillimeter = LengthConversion.convert(LengthUnit.INCH, LengthUnit.MILLIMETER, 5);

            // Assert
            Assert.Equal(127m, toMillimeter);
        }

        [Fact]
        public void ConvertToCentimeter()
        {
            // Act
            decimal toCentimeter = LengthConversion.convert(LengthUnit.INCH, LengthUnit.CENTIMETER, 5);

            // Assert
            Assert.Equal(12.7m, toCentimeter);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Act
            decimal toMeter = LengthConversion.convert(LengthUnit.INCH, LengthUnit.METER, 5);

            // Assert
            Assert.Equal(0.127m, toMeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Act
            decimal toKilometer = LengthConversion.convert(LengthUnit.INCH, LengthUnit.KILOMETER, 5);

            // Assert
            Assert.Equal(0.000127m, toKilometer);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Act
            decimal toFoot = LengthConversion.convert(LengthUnit.INCH, LengthUnit.FOOT, 5);

            // Assert
            Assert.Equal(0.4166666666666666666666666667m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Act
            decimal toYard = LengthConversion.convert(LengthUnit.INCH, LengthUnit.YARD, 5);

            // Assert
            Assert.Equal(0.1388888888888888888888888889m, toYard);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Act
            decimal toInch = LengthConversion.convert(LengthUnit.INCH, LengthUnit.INCH, 5);

            // Assert
            Assert.Equal(5m, toInch);
        }
    }
}
