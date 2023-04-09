using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        /// <summary>
        /// Движение фигуры по заданному направлению 
        /// </summary>
        /// <param name="dir">Направление сдвига фигуры</param>
        public void Move(Direction dir)
        {
            foreach(var p in _points)
            {
                p.Move(dir);
            }
        }

        /// <summary>
        /// Скрывает фигуру в консоли
        /// </summary>
        public void Hide()
        {
            foreach(var p in _points)
            {
                p.Hide();
            }
        }

       



        
    }
}
