﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem4_2
{
    public class Triangle : PlaneFigure
    {
        public Triangle()
        {
        }

        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double Area
        {
            get { return width * height / 2.0; }
        }
    }
}
