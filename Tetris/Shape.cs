using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    [Serializable]
    public class Shape
    {
        /// <summary>
        /// Массив точек фигуры (Всегда 4 точки)
        /// </summary>
        protected Point[] _points = new Point[4];


        /// <summary>
        /// Отрисовка фигуры
        /// </summary>
        public void Draw()
        {
            foreach(var p in _points)
            {
                p.Draw();
            }
        }



        
    }
}
