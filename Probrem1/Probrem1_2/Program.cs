﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c1 = new Calc();
            Calc c2 = new Calc(3, 1);
            c1.Num1 = 1;
            c1.Num2 = 2;

            c1.ShowAdd();
            c2.ShowAdd();
        }
    }
}
