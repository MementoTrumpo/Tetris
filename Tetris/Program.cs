using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitializationApplication();

            int x1 = 2;
            int y1 = 5;
            char symbol = '*';

            int x2 = 5;
            int y2 = 8;
            char symbol_2 = '@';

            int x3 = 10;
            int y3 = 29;
            char symbol_3 = '#';

            ShowToConsole(x1, y1, symbol);
            ShowToConsole(x2, y2, symbol_2);
            ShowToConsole(x3, y3, symbol_3);

            Console.ReadKey();
        }

        private static void ShowToConsole(int xPos, int yPos, char value)
        {
            Console.SetCursorPosition(yPos, xPos);
            Console.Write(value);
        }

        private static void InitializationApplication()
        {
            NameValueCollection allApplicationSettings = ConfigurationManager.AppSettings;

            int consoleWidth = int.Parse(allApplicationSettings["ConsoleWidth"]);
            int consoleHeight = int.Parse(allApplicationSettings["ConsoleHeight"]);

            Console.SetWindowSize(consoleWidth, consoleHeight);
            Console.SetBufferSize(consoleWidth, consoleHeight);
        }
    }
}