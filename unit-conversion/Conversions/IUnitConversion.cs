using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Conversions
{
    internal interface IUnitConversion
    {
        decimal convert(string convertTo, decimal value);
    }
}
