using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion;
using unit_conversion.Enums;

namespace unit_conversion_test.Length
{
    public class MeterConversionTest
    {
        [Fact]
        public void ConvertToCentimeter()
        {
            // Act
            decimal toCentimeter = LengthConversion.convert(LengthUnit.METER, LengthUnit.CENTIMETER, 5);

            // Assert
            Assert.Equal(500m, toCentimeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Act
            decimal toKilometer = LengthConversion.convert(LengthUnit.METER, LengthUnit.KILOMETER, 5);

            // Assert
            Assert.Equal(0.005m, toKilometer);
        }

        [Fact]
        public void ConvertToMillimeter()
        {
            // Act
            decimal toMillimeter = LengthConversion.convert(LengthUnit.METER, LengthUnit.MILLIMETER, 5);

            // Assert
            Assert.Equal(5000m, toMillimeter);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Act
            decimal toInch = LengthConversion.convert(LengthUnit.METER, LengthUnit.INCH, 5);

            // Assert
            Assert.Equal(196.85039370078740157480314961m, toInch);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Act
            decimal toFoot = LengthConversion.convert(LengthUnit.METER, LengthUnit.FOOT, 5);

            // Assert
            Assert.Equal(16.404199475065616797900262467m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Act
            decimal toYard = LengthConversion.convert(LengthUnit.METER, LengthUnit.YARD, 5);

            // Assert
            Assert.Equal(5.4680664916885389326334208224m, toYard);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Act
            decimal toMeter = LengthConversion.convert(LengthUnit.METER, LengthUnit.METER, 5);

            // Assert
            Assert.Equal(5m, toMeter);
        }
    }
}
