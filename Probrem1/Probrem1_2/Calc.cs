using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem1_2
{
    public class Calc
    {
        private int num1;
        private int num2;

        public Calc()
        {
        }

        public Calc(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Num1
        {
            set { num1 = value; }
            get { return num1; }
        }

        public int Num2
        {
            set { num2 = value; }
            get { return num2; }
        }

        public void ShowAdd()
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        }
    }
}
