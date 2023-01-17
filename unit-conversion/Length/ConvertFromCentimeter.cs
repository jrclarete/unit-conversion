using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Length
{
    internal class ConvertFromCentimeter : IUnitConversion
    {
        private Dictionary<string, Func<decimal, decimal>> MethodDict = new Dictionary<string, Func<decimal, decimal>>();

        private void initMethodList()
        {
            MethodDict.Add(LengthConversion.MILLIMETER, (value) => { ConvertFromCentimeter instance = new ConvertFromCentimeter(); return instance.ConvertToMillimeter(value); });
            MethodDict.Add(LengthConversion.METER, (value) => { ConvertFromCentimeter instance = new ConvertFromCentimeter(); return instance.ConvertToMeter(value); });
            MethodDict.Add(LengthConversion.KILOMETER, (value) => { ConvertFromCentimeter instance = new ConvertFromCentimeter(); return instance.ConvertToKilometer(value); });
            MethodDict.Add(LengthConversion.INCH, (value) => { ConvertFromCentimeter instance = new ConvertFromCentimeter(); return instance.ConvertToInch(value); });
            MethodDict.Add(LengthConversion.FOOT, (value) => { ConvertFromCentimeter instance = new ConvertFromCentimeter(); return instance.ConvertToFoot(value); });
            MethodDict.Add(LengthConversion.YARD, (value) => { ConvertFromCentimeter instance = new ConvertFromCentimeter(); return instance.ConvertToYard(value); });
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

        private decimal ConvertToMillimeter(decimal value)
        {
            return value * 10m;
        }

        private decimal ConvertToMeter(decimal value)
        {
            return value / 100m;
        }

        private decimal ConvertToKilometer(decimal value)
        {
            return value / 100000m;
        }

        private decimal ConvertToInch(decimal value)
        {
            return value / 2.54m;
        }

        private decimal ConvertToFoot(decimal value)
        {
            return value / 30.48m;
        }

        private decimal ConvertToYard(decimal value)
        {
            return value / 91.44m;
        }
    }
}
