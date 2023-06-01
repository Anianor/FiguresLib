using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public interface ITriangle :IOperation
    {       
        public bool IsRightTriangle();
        public bool IsThisATriangle();
    }
}
