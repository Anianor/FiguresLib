using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    class Circles : Circle
    {
        const double PI = Math.PI;
        double R { get; }
        internal Circles(double R)
        {
            this.R = R;
        }
        public double Square() => Square(R);
        private double Square(double R)
        {
            return PI * Math.Pow(R, 2);
        }

        public  double P()
        {
            return R;
        }
    }
}
