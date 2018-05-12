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

        /// <summary>
        /// Лічильник якусів для рандомної генерації.
        /// </summary>
        private int Counter;

        /// <summary>
        /// Кількість рядків в масиві.
        /// </summary>
        private int rows;

        /// <summary>
        /// Кількість стовбців в масиві.
        /// </summary>
        private int cols;

        /// <summary>
        /// Створення нового рівня
        /// </summary>
        /// <param name="Counter">Лічильник ярусів для рандомної генерації</param>
        /// <param name="sea">Масив з рибками</param>
        /// 
        public void StartNewLevel(int Counter, SmallFish [,] sea)
        {
            if (sea.Length != this.sea.Length)
                throw new Exception("Розмірності масивів не співпадають");

            this.Counter = Counter;
            this.sea = sea;
        }

        /// <summary>
        /// Конструктор SeaClass
        /// </summary>
        /// <param name="cols">Кількість стовбців</param>
        /// <param name="rows">Кількість рядків</param>
        public SeaClass(int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;
            sea = new SmallFish[rows, cols]; // ініціалізація розмірнсті.

            for (int i = 0; i < rows; i++) // Заповнення null.
                for (int j = 0; j < cols; j++)
                    sea[i, j] = null;
        }
    }
}
