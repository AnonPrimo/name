using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name.View
{
    class Level {

        public int []GetThrowFish() // ввід з якого стовбця і в який кинути рибу
        {
            int[] GetThrow = new int[2];
            Console.Write("Рядок з якого взяти рибу: ");
            int.TryParse(Console.ReadLine(), out (GetThrow[0]));
            Console.Write("Рядок у який кинути рибу: ");
            int.TryParse(Console.ReadLine(), out (GetThrow[1]));
            return GetThrow;
        }
        
        public void ShowFishes(int length, int width, char[,] Fishes) // вивід риб
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (Fishes[i, j] == 's' || Fishes[i, j] == 'S')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (Fishes[i, j] == 'm' || Fishes[i, j] == 'M')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (Fishes[i, j] == 'b' || Fishes[i, j] == 'B')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                    Console.Write(Fishes[i, j]);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" ▓ ");
                }
                Console.WriteLine();
            }
        }

        public void StartLevel1()
        {
            Console.WriteLine("\nLEVEL 1\n");
            int length = 3;
            int width = 3;
            // SmallFish[,] Fishes = new SmallFish[lenght, width]; // масив риб у грі.

           char [,]Fishes = new char[length, width];
            Fishes[0,0] = 's';
            Fishes[0, 1] = ' ';
            Fishes[0, 2] = ' ';
            Fishes[1, 0] = ' ';
            Fishes[1, 1] = ' ';
            Fishes[1, 2] = ' ';
            Fishes[2, 0] = ' ';
            Fishes[2, 1] = 'm';
            Fishes[2, 2] = 'b';
            ShowFishes(length, width, Fishes);
            Console.ReadKey();
        }

    }
}
