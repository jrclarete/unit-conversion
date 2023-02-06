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
        public void ConvertToSqCentimeter()
        {
            // Act
            decimal toSqCentimeter = AreaConversion.convert(AreaUnit.SQMETER, AreaUnit.SQCENTIMETER, 5);

            // Assert
            Assert.Equal(50000m, toSqCentimeter);
        }

        [Fact]
        public void ConvertToSqMeter()
        {
            // Act
            decimal toSqMeter = AreaConversion.convert(AreaUnit.SQMETER, AreaUnit.SQMETER, 5);

            // Assert
            Assert.Equal(5m, toSqMeter);
        }

        [Fact]
        public void ConvertToSqKilometer()
        {
            // Act
            decimal toSqKilometer = AreaConversion.convert(AreaUnit.SQMETER, AreaUnit.SQKILOMETER, 5);

            // Assert
            Assert.Equal(0.000005m, toSqKilometer);
        }
    }
}
