using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public static class Figures
    {
        public static ITriangle Triangle(double X, double Y, double Z) => new Triangles(X, Y, Z);
        public static ICircle Circle(double param) => new Circles(param);

        public static ICircle Figure(double R)
        {
            return Circle(R);
        }
        public static ITriangle Figure(double X, double Y, double Z)
        {
            return Triangle(X, Y, Z);
        }
    }
}
