using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black; /// устанавливаем цвет
            Console.BackgroundColor = ConsoleColor.Cyan;  /// устанавливаем цвет
            Console.Clear();
            //Console.WriteLine("Hello World");
            View.mainView m = new View.mainView();
            m.StartGame();
            Console.ResetColor(); /// сбрасываем в стандартный
            Console.ReadKey();
        }
    }
}
