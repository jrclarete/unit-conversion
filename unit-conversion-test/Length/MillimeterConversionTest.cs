using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;
using unit_conversion.Enums;

namespace unit_conversion_test.Length
{
    public class MillimeterConversionTest
    {
        [Fact]
        public void ConvertToCentimeter()
        {
            // Act
            decimal toCentimeter = LengthConversion.convert(LengthUnit.MILLIMETER, LengthUnit.CENTIMETER, 5);

            // Assert
            Assert.Equal(0.5m, toCentimeter);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Act
            decimal toMeter = LengthConversion.convert(LengthUnit.MILLIMETER, LengthUnit.METER, 5);

            // Assert
            Assert.Equal(0.005m, toMeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Act
            decimal toKilometer = LengthConversion.convert(LengthUnit.MILLIMETER, LengthUnit.KILOMETER, 5);

            // Assert
            Assert.Equal(0.000005m, toKilometer);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Act
            decimal toInch = LengthConversion.convert(LengthUnit.MILLIMETER, LengthUnit.INCH, 5);

            // Assert
            Assert.Equal(0.1968503937007874015748031496m, toInch);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Act
            decimal toFoot = LengthConversion.convert(LengthUnit.MILLIMETER, LengthUnit.FOOT, 5);

            // Assert
            Assert.Equal(0.0164041994750656167979002625m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Act
            decimal toYard = LengthConversion.convert(LengthUnit.MILLIMETER, LengthUnit.YARD, 5);

            // Assert
            Assert.Equal(0.0054680664916885389326334208m, toYard);
        }

        [Fact]
        public void ConvertToMillimeter()
        {
            // Act
            decimal toCentimeter = LengthConversion.convert(LengthUnit.MILLIMETER, LengthUnit.MILLIMETER, 5);

            // Assert
            Assert.Equal(5m, toCentimeter);
        }
    }
}
