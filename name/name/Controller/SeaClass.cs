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

       
        private int Counter;

        
        private int rows;

        
        private int cols;

        
        public void StartNewLevel(int Counter, SmallFish [,] sea)
        {
            if (sea.Length != this.sea.Length)
                throw new Exception("Розмірності масивів не співпадають");

            this.Counter = Counter;
            this.sea = sea;
        }

        
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
