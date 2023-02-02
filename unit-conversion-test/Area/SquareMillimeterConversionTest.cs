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
        public void ConvertToSqMeter()
        {
            // Act
            decimal toSqMeter = AreaConversion.convert(AreaUnit.SQMILLIMETER, AreaUnit.SQMETER, 5);

            // Assert
            Assert.Equal(0.000005m, toSqMeter);
        }

        [Fact]
        public void ConvertToSqKilometer()
        {
            // Act
            decimal toSqKilometer = AreaConversion.convert(AreaUnit.SQMILLIMETER, AreaUnit.SQKILOMETER, 5);

            // Assert
            Assert.Equal(0.000000000005m, toSqKilometer);
        }

        [Fact]
        public void ConvertToSqInch()
        {
            // Act
            decimal toSqInch = AreaConversion.convert(AreaUnit.SQMILLIMETER, AreaUnit.SQINCH, 5);

            // Assert
            Assert.Equal(0.007750015500031000062000124m, toSqInch);
        }

        [Fact]
        public void ConvertToSqFoot()
        {
            // Act
            decimal toSqFoot = AreaConversion.convert(AreaUnit.SQMILLIMETER, AreaUnit.SQFOOT, 5);

            // Assert
            Assert.Equal(0.0000538195520835486115416675m, toSqFoot);
        }

        [Fact]
        public void ConvertToSqYard()
        {
            // Act
            decimal toSqYard = AreaConversion.convert(AreaUnit.SQMILLIMETER, AreaUnit.SQYARD, 5);

            // Assert
            Assert.Equal(0.0000059799502315054012824075m, toSqYard);
        }

        [Fact]
        public void ConvertToSqMile()
        {
            // Act
            decimal toSqMile = AreaConversion.convert(AreaUnit.SQMILLIMETER, AreaUnit.SQMILE, 5);

            // Assert
            Assert.Equal(0.0000000000019305093842061166m, toSqMile);
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
