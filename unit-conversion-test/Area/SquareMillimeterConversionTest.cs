using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Enums;
using unit_conversion;

namespace unit_conversion_test.Area
{
    public class SquareMillimeterConversionTest
    {
        [Fact]
        public void ConvertToSqCentimeter()
        {
            // Act
            decimal toSqCentimeter = AreaConversion.convert(AreaUnit.SQMILLIMETER, AreaUnit.SQCENTIMETER, 5);

            // Assert
            Assert.Equal(0.05m, toSqCentimeter);
        }

        [Fact]
        public void ConvertToSqMillimeter()
        {
            // Act
            decimal toSqMillimeter = AreaConversion.convert(AreaUnit.SQMILLIMETER, AreaUnit.SQMILLIMETER, 5);

            // Assert
            Assert.Equal(5m, toSqMillimeter);
        }
    }
}
