﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_conversion.Length;

namespace unit_conversion_test.Length
{
    public class UnitMillimeterTest
    {
        [Fact]
        public void ConvertToCentimeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toCentimeter = length.convert(LengthConversion.MILLIMETER, LengthConversion.CENTIMETER, 5);

            // Assert
            Assert.Equal(0.5m, toCentimeter);
        }

        [Fact]
        public void ConvertToMeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toMeter = length.convert(LengthConversion.MILLIMETER, LengthConversion.METER, 5);

            // Assert
            Assert.Equal(0.005m, toMeter);
        }

        [Fact]
        public void ConvertToKilometer()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toKilometer = length.convert(LengthConversion.MILLIMETER, LengthConversion.KILOMETER, 5);

            // Assert
            Assert.Equal(0.000005m, toKilometer);
        }

        [Fact]
        public void ConvertToInch()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toInch = length.convert(LengthConversion.MILLIMETER, LengthConversion.INCH, 5);

            // Assert
            Assert.Equal(0.1968503937007874015748031496m, toInch);
        }

        [Fact]
        public void ConvertToFoot()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toFoot = length.convert(LengthConversion.MILLIMETER, LengthConversion.FOOT, 5);

            // Assert
            Assert.Equal(0.0164041994750656167979002625m, toFoot);
        }

        [Fact]
        public void ConvertToYard()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toYard = length.convert(LengthConversion.MILLIMETER, LengthConversion.YARD, 5);

            // Assert
            Assert.Equal(0.0054680664916885389326334208m, toYard);
        }

        [Fact]
        public void ConvertToMillimeter()
        {
            // Arrange
            LengthConversion length = new LengthConversion();

            // Act
            decimal toCentimeter = length.convert(LengthConversion.MILLIMETER, LengthConversion.MILLIMETER, 5);

            // Assert
            Assert.Equal(5m, toCentimeter);
        }
    }
}