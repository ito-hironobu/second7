using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem4_2
{
    public abstract class PlaneFigure
    {
        //protected double area = 0; // ←問題の指定通りにやるならいる？？
        protected double width = 0;
        protected double height = 0;

        public PlaneFigure()
        {
        }

        public PlaneFigure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            set { width = value; }
            get { return width; }
        }

        public double Height
        {
            set { height = value; }
            get { return height; }
        }

        public abstract double Area
        {
            get;
        }
    }
}
