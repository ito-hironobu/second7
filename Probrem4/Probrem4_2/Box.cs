using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem4_2
{
    public class Box : PlaneFigure
    {
        public Box()
        {
        }

        public Box(double width, double height) : base(width, height)
        {
        }

        public override double Area
        {
            get { return width * height; }
        }
    }
}
