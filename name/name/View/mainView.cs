using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name.View
{
    class mainView
    {
        public void StartGame()
        {
            //Console.SetWindowSize(500, 500);
            Console.ForegroundColor = ConsoleColor.Black; 
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.Title = "GAME FISH";
            Level l = new Level();
            l.TestFunc();
        }
    }
}