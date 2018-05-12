using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using name.Model;

namespace name.Controller
{
    class SeaClass
    {
        SmallFish[,] sea = new SmallFish[,] {
               { new SmallFish(),   new MediumFish(),   new BigFish() },
               { null,              null,               null},
               { null,              null,               null}
            };

        SmallFish currentFish;
        SmallFish findFish;

        /// Лічильник якусів для рандомної генерації.

        private int Counter; 

        /// <summary>
        /// Створення нового рівня
        /// </summary>
        /// <param name="Counter">Лічильник ярусів для рандомної генерації</param>
        /// <param name="sea">Масив з рибками</param>
        public void StartNewLevel(int Counter, SmallFish [,] sea)
        {
            this.Counter = Counter;
            this.sea = sea;
        }

        public SeaClass()
        {
            ///random sea generation
        }

        public SmallFish find(int a)
        {
            for (int i = (int)Math.Sqrt(sea.Length) - 1; i >= 0; i--)
            {
                if (sea[i, a] != null)
                {
                    return sea[i, a];
                }
            }
            return null;
        }

        public void Position(int a, int b)
        {
            currentFish = find(a);
            findFish = find(b);
            
            
        }


      
        public SmallFish[,] Sea(int n)
        {
            int fishSize = n + 2, size = n * 3;
          
            //for (int i = 0; i < fishSize; i++)
            //    for (int j = 0; j < size; j++)
            //        sea[i, j] = ' ';        //fill "sea" with spaces

           // Fish fish = new Controller.Fish();

            //Random rand = new Random();
            //for (int i = 0; i < fishSize; i++)
            //{
            //    int col = rand.Next(1, size);
            //    int row = rand.Next(1, size);

            //    if (sea[row, col] == ' ')
            //        sea[row, col] = ;      //random fill "fish"
            //    else
            //        i--;
            //}

            //for (int i = fishSize - 1; i > 0; i--)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        if (sea[i, j] != ' ')
            //        {
            //            while (true)
            //            {
            //                if (sea[i - 1, j] != ' ')
            //                    break;
            //                sea[i - 1, j] = sea[i, j];  //підйом риби якомога вище
            //                sea[i, j] = ' ';
            //            }
            //        }
            //    }
            //}

            return sea;
        }
    }
}
