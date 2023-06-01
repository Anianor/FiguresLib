using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    class Circles:ICircle
    {
        const double PI = Math.PI;
        double R { get; }
        internal Circles(double R)
        {
            
            this.R = R;
        }
        public double Square()
        {
            if (R < 0)
                throw new ArgumentException($"parameter {nameof(R)} cannot be less than 0");
            return Square(R); 
        }
        private double Square(double R)
        {
            return PI * Math.Pow(R, 2);
        }
        

    }
}
