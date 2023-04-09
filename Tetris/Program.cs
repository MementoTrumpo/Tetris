using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Linq;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitializationApplication();
            Console.WriteLine(Console.WindowHeight);
            Console.WriteLine(Console.WindowWidth);
            Console.WriteLine(Console.BufferHeight);
            Console.WriteLine(Console.BufferWidth);
            Console.WriteLine(Console.LargestWindowHeight);
            Console.WriteLine(Console.LargestWindowWidth);

            Stick stick = new Stick(new Point(4, 10, '#'));
            stick.Draw();

            Random rand = new Random();

            //Shape[] shapes = new Shape[3];
            //for(int i = 0; i < shapes.Length; i++)
            //{
            //    shapes[i] = new Square(new Point(rand.Next(1, 10), rand.Next(4, 18), '#')) ;
            //    shapes[i].Draw();
            //}

            Shape square = new Square(new Point(rand.Next(2, 22), rand.Next(4, 22), '#'));
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);

                square.Hide();
                square.Move(Direction.DOWN);
                square.Draw();


            }

            Console.ReadLine();

        }

        private static void Refresh(object obj)
        {
            //Console.Clear();
            //InitializationApplication();

            
        }

        private Timer _timer = null;

        private static void TimerCallback(Object o)
        {
            // Display the date/time when this method got called.
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
        }

        private static void MovingSquare(object s)
        {
            //Refresh();

            Square square = (Square)s;
            
            //square.Refresh();

            
        }


        /// <summary>
        /// Инициализация игрового поля перед запуском игры
        /// </summary>
        private static void InitializationApplication()
        {
            NameValueCollection allApplicationSettings = ConfigurationManager.AppSettings;

            int consoleWidth = int.Parse(allApplicationSettings["ConsoleWidth"]);
            int consoleHeight = int.Parse(allApplicationSettings["ConsoleHeight"]);

            Console.SetWindowSize(consoleWidth, consoleHeight);
            Console.SetBufferSize(consoleWidth, consoleHeight);


            DrawingFieldBoundaries(consoleWidth, consoleHeight);
        }

        /// <summary>
        /// Отрисовка границ игрового поля и названия игры
        /// </summary>
        /// <param name="width">Ширина поля</param>
        /// <param name="height">Высота поля</param>
        private static void DrawingFieldBoundaries(int width, int height)
        {
            const int COUNT_SYMBOL_OF_TETRIS = 6;

            for (int i = 0; i < height; i++)
            {
                //Создаем рисунок для заполнения с пустотами
                string pattern = "|" + new string(' ', width - 2) + "|";

                if (i == 0 || i == 2 || i == height - 1)
                {
                    Console.Write(new string('-', width));
                }
                else if (i == 1)
                {
                    //Создаем пробелы между названием и крайнимим символами
                    string pattern_2 = new string(' ', (width - COUNT_SYMBOL_OF_TETRIS - 2) / 2);
                    //Аналогичная строка, только для случая, когда размер удет совпадать с шириной поля
                    string str = "|" + pattern_2 + "TETRIS" + pattern_2 + "|";
                    if(str.Length < width)
                    {
                        //Повторяем процедуру для длины, когда количество символов меньше
                        str = "|" + pattern_2 + "TETRIS" + pattern_2 
                                  + new string(' ', width - str.Length) + "|";
                        Console.Write(str);
                    }
                    else
                    {
                        Console.Write(str);
                    }
                }

                else
                {
                    Console.Write(pattern);
                }
            }
            Console.SetCursorPosition(0, 0);
        }

            
        
    }
}