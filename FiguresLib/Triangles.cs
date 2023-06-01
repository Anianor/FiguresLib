using FiguresLib;

namespace FiguresLib
{
    class Triangles : ITriangle
    {
        private double X { get; }
        private double Y { get; }
        private double Z { get; }

        internal Triangles(
                double x,
                double y,
                double z)
        {           
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double Square() => Square(X, Y, Z);
        public bool IsRightTriangle() => IsRightTriangle(X, Y, Z);
        public bool IsThisATriangle() => IsThisATriangle(X, Y, Z);
        private double Square(double x,double y,double z)
        {
            if(!IsValidValue(x,y,z))
            {
                throw new ArgumentException($"The side of the triangle cannot be <= 0");
            }
            if (!IsThisATriangle(x, y, z))
            {
                Console.WriteLine("Фигура не является треугольником");
                throw new ArgumentOutOfRangeException("Not a triangle");
            }
            var p = (x + y + Z) / 2;
            var S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
        private bool IsRightTriangle(double x, double y, double z)
        {
            if (!IsValidValue(x, y, z))
            {                
                throw new ArgumentException($"The side of the triangle cannot be <= 0");
            }
            return (Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(z, 2) ||
                Math.Pow(z, 2) + Math.Pow(y, 2) == Math.Pow(x, 2) ||
                Math.Pow(x, 2) + Math.Pow(z, 2) == Math.Pow(y, 2));
        }
        private bool IsThisATriangle(double x, double y, double z)
        {
            return (x + y > z && x + z > y && y + z > x);
        }
        private bool IsValidValue(double x, double y, double z)
        {
            if (x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Ни одно значение не может быть <= 0");
                return false;
            }
            return true;
        }


    }
}