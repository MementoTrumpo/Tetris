using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Point
    {
        /// <summary>
        /// Позиция по оси X
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Позиция по оси Y
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Символ, который будет выводиться на экран
        /// </summary>
        public char Symbol { get; set; }

        public Point(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        /// <summary>
        /// Выводит на экран символ в определенном месте
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);

        }
    }
}
