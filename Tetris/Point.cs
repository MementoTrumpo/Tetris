using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Point
    {
        /// <summary>
        /// Размер сдвига точки
        /// </summary>
        private const int SHIFT_SIZE = 1;

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

        public Point()
        {
        }

        /// <summary>
        /// Выводит на экран символ в определенном месте
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);

        }

        /// <summary>
        /// Сдвигает точку на заданную координату
        /// </summary>
        public void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.DOWN:
                    Y += SHIFT_SIZE;
                    break;
                case Direction.LEFT:
                    X -= SHIFT_SIZE;
                    break;
                case Direction.RIGHT:
                    X += SHIFT_SIZE;
                    break;
            }

        }

        /// <summary>
        /// Скрывает точку
        /// </summary>
        public void Hide()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }
    }
}
