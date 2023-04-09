using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Stick : Shape
    {
        public Stick(Point p)
        {
            for(int i = 0; i < _points.Length; i++)
            {
                _points[i] = new Point(p.X, p.Y, p.Symbol);
                p.Y++;
            }
        }
    }
}
