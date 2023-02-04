﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Enums;
using unit_conversion;

namespace unit_conversion_test.Area
{
    public class SqCentimeterConversionTest
    {
        [Fact]
        public void ConvertToSqMillimeter()
        {
            // Act
            decimal toSqMillimeter = AreaConversion.convert(AreaUnit.SQCENTIMETER, AreaUnit.SQMILLIMETER, 5);

            // Assert
            Assert.Equal(500m, toSqMillimeter);
        }

        [Fact]
        public void ConvertToSqMeter()
        {
            // Act
            decimal toSqMeter = AreaConversion.convert(AreaUnit.SQCENTIMETER, AreaUnit.SQMETER, 5);

            // Assert
            Assert.Equal(0.0005m, toSqMeter);
        }

        [Fact]
        public void ConvertToSqKilometer()
        {
            // Act
            decimal toSqKilometer = AreaConversion.convert(AreaUnit.SQCENTIMETER, AreaUnit.SQKILOMETER, 5);

            // Assert
            Assert.Equal(0.0000000005m, toSqKilometer);
        }

        [Fact]
        public void ConvertToSqInch()
        {
            // Act
            decimal toSqInch = AreaConversion.convert(AreaUnit.SQCENTIMETER, AreaUnit.SQINCH, 5);

            // Assert
            Assert.Equal(0.7750015500031000062000124m, toSqInch);
        }

        [Fact]
        public void ConvertToSqFoot()
        {
            // Act
            decimal toSqFoot = AreaConversion.convert(AreaUnit.SQCENTIMETER, AreaUnit.SQFOOT, 5);

            // Assert
            Assert.Equal(0.0053819552083548611541667528m, toSqFoot);
        }

        [Fact]
        public void ConvertToSqCentimeter()
        {
            // Act
            decimal toSqCentimeter = AreaConversion.convert(AreaUnit.SQCENTIMETER, AreaUnit.SQCENTIMETER, 5);

            // Assert
            Assert.Equal(5m, toSqCentimeter);
        }
    }
}
