using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Length
{
    internal class ConvertFromMillimeter : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodDict = new Dictionary<string, Func<decimal, decimal>>();

        private void initMethodList()
        {
            MethodDict.Add(LengthConversion.CENTIMETER, (value) => { ConvertFromMillimeter instance = new ConvertFromMillimeter(); return instance.ConvertToCentimeter(value); });
            MethodDict.Add(LengthConversion.METER, (value) => { ConvertFromMillimeter instance = new ConvertFromMillimeter(); return instance.ConvertToMeter(value); });
            MethodDict.Add(LengthConversion.KILOMETER, (value) => { ConvertFromMillimeter instance = new ConvertFromMillimeter(); return instance.ConvertToKilometer(value); });
            MethodDict.Add(LengthConversion.INCH, (value) => { ConvertFromMillimeter instance = new ConvertFromMillimeter(); return instance.ConvertToInch(value); });
            MethodDict.Add(LengthConversion.FOOT, (value) => { ConvertFromMillimeter instance = new ConvertFromMillimeter(); return instance.ConvertToFoot(value); });
            MethodDict.Add(LengthConversion.YARD, (value) => { ConvertFromMillimeter instance = new ConvertFromMillimeter(); return instance.ConvertToYard(value); });
        }

        public decimal convert(string convertTo, decimal value)
        {
            initMethodList();

            decimal convertedValue = 0m;

            if (MethodDict.ContainsKey(convertTo))
            {
                convertedValue = MethodDict[convertTo](value);
            }
            else
            {
                convertedValue = value;
            }

            return convertedValue;
        }

        private decimal ConvertToCentimeter(decimal value)
        {
            return value / 10m;
        }

        private decimal ConvertToMeter(decimal value)
        {
            return value / 1000m;
        }

        private decimal ConvertToKilometer(decimal value)
        {
            return value / 1000000m;
        }

        private decimal ConvertToInch(decimal value)
        {
            return value / 25.4m;
        }

        private decimal ConvertToFoot(decimal value)
        {
            return value / 304.8m;
        }

        private decimal ConvertToYard(decimal value)
        {
            return value / 914.4m;
        }
    }
}
