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
        public void ConvertToSqKilometer()
        {
            // Act
            decimal toSqKilometer = AreaConversion.convert(AreaUnit.SQMETER, AreaUnit.SQKILOMETER, 5);

            // Assert
            Assert.Equal(0.000005m, toSqKilometer);
        }

        [Fact]
        public void ConvertToSqInch()
        {
            // Act
            decimal toSqInch = AreaConversion.convert(AreaUnit.SQMETER, AreaUnit.SQINCH, 5);

            // Assert
            Assert.Equal(7750.0155m, toSqInch);
        }

        [Fact]
        public void ConvertToSqFoot()
        {
            // Act
            decimal toSqFoot = AreaConversion.convert(AreaUnit.SQMETER, AreaUnit.SQFOOT, 5);

            // Assert
            Assert.Equal(53.81955208354861154166752778m, toSqFoot);
        }

        [Fact]
        public void ConvertToSqYard()
        {
            // Act
            decimal toSqYard = AreaConversion.convert(AreaUnit.SQMETER, AreaUnit.SQYARD, 5);

            // Assert
            Assert.Equal(5.9799502315054012824075030866m, toSqYard);
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
