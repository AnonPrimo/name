using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using name.Model;

namespace name.View
{
    class Level {



        /// <summary>
        /// Метод конвертує масив риб у масив символів
        /// </summary>
        /// <param name="length"> к-сть рядків і стовбців квадратної матриці </param>
        /// <param name="width"> к-сть рядків і стовбців квадратної матриці </param>
        /// <param name="Fish"> Масив риб </param>
        /// <returns> Повертає матрицю символів </returns>
        public char[,] ConvertToChar(SmallFish[,]Fish, int length, int width)
        {
            char[,] CharFish = new char[length, width];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (Fish[i, j] == null) CharFish[i, j] = ' ';
                    else CharFish[i,j] = Fish[i, j].N;
                }
            }
            return CharFish;
        }


        /// <summary>
        /// Метод виводить масив риб на екран
        /// </summary>
        /// <param name="length"> к-сть рядків і стовбців квадратної матриці </param>
        /// <param name="Sea"> Масив риб для виводу на екран </param>
        public void ShowFishes(SmallFish[,] Sea)
        {

            int length = Sea.GetLength(0);
            int width = Sea.GetLength(1);
            char[,] Fishes = new char[length, width];
            Fishes = ConvertToChar(Sea, length, width);
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


       /// <summary>
       /// перемальовує масив риб
       /// </summary>
       /// <param name="length">рядки</param>
       /// <param name="width">стовбці</param>
       /// <param name="Sea">масив риб</param>
        public void RefreshConsole(SmallFish[,]Sea)
        {
            Console.Clear();
            ShowFishes(Sea);
        }

        /// <summary>
        /// test function
        /// </summary>
        public void TestFunc()
        {

            Console.WriteLine("\nLEVEL 1\n");
            int length = 10;
            int width = 5;

            SmallFish[,] Fishes = new SmallFish[length, width];
            Fishes[0, 0] = new SmallFish();
            Fishes[0, 1] = new MediumFish();
            Fishes[0, 2] = new BigFish();
            ShowFishes(Fishes);
            Console.ReadKey();
            Fishes[0, 1] = new SmallFish();
            RefreshConsole(Fishes);
            Console.ReadKey();
        }



    }
}
