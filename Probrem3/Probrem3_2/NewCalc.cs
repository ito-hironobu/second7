using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem3_2
{
    public class NewCalc : FundCalc
    {
        public double Mul()
        {
            return number1 * number2;
        }

        public double Div()
        {
            return number1 / number2;
        }
    }
}
