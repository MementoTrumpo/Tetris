using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tetris
{
    public partial class Square: Shape
    {

        public Square(Point p)
        {
            _points[0] = new Point(p.X, p.Y, p.Symbol);
            _points[1] = new Point(p.X + 1, p.Y, p.Symbol);
            _points[2] = new Point(p.X, p.Y + 1, p.Symbol);
            _points[3] = new Point(p.X + 1, p.Y + 1, p.Symbol);

        }

    }
}
