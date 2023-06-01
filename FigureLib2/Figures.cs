using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public abstract class Figures
    {

        public static Triangle Triangle(double X, double Y, double Z) => new Triangles(X, Y, Z);
        public static Circle Circle(double param) => new Circles(param);

        public static Circle Figure(double R)
        {
            return Circle(R);
        }
        public static Triangle Figure(double X, double Y, double Z)
        {
            return Triangle(X, Y, Z);
        }
    }
    
}
