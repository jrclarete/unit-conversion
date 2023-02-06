using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Enums;
using unit_conversion;

namespace unit_conversion_test.Area
{
    public class SqMeterConversionTest
    {
        [Fact]
        public void ConvertToSqMillimeter()
        {
            // Act
            decimal toSqMillimeter = AreaConversion.convert(AreaUnit.SQMETER, AreaUnit.SQMILLIMETER, 5);

            // Assert
            Assert.Equal(5000000m, toSqMillimeter);
        }

        [Fact]
        public void ConvertToSqMeter()
        {
            // Act
            decimal toSqMeter = AreaConversion.convert(AreaUnit.SQMETER, AreaUnit.SQMETER, 5);

            // Assert
            Assert.Equal(5m, toSqMeter);
        }
    }
}
