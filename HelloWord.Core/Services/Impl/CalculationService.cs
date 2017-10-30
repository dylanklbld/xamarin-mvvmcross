using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Core.Services.Impl
{
    public class CalculationService: ICalculationService
    {
        public double TipAmount(double subTotal, int generosity)
        {
            return subTotal * ((double)generosity)/100.0;
        }
    }
}
