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
        private int rows;
        private int cols;
        private int Counter;


        public void find(int a)
        {
            currentFish = null;
            for (int i = sea.GetLength(0)-1; i >= 0; i--)
            {
                if (sea[i, a] != null)
                {
                    currentFish = sea[i, a];
                    sea[i, a] = null;
                    break;
                }
            }
        }



        public int isFish(int x)
        {
            for (int i = (int)Math.Sqrt(sea.Length) - 1; i >= 0; i--)
                if (sea[i, x] != null)
                    return i;
            return -1;
        }


        private bool Position(out SmallFish f, out int x, int b)
        {
            f = null;
            x = isFish(b);
            if (x + 1 >= sea.Length)
                return false;
            if (x == -1)
            {
                sea[0, b] = currentFish;
                currentFish = null;
                return false;
            }

            f = sea[x, b];
            return true;
        }


        public void StartNewLevel(int Counter, SmallFish[,] sea)
        {
            if (sea.Length != this.sea.Length)
                throw new Exception("Розмірності масивів не співпадають");

            this.Counter = Counter;
            this.sea = sea;
        }
        public bool push(int b)
        {
            if (currentFish == null) return false;


            int x;
            SmallFish previosFish;
            if (!Position(out previosFish, out x, b))
                return false;

            if (currentFish is MediumFish && previosFish is BigFish)
            {
                if (((BigFish)previosFish).Eat())
                {
                    sea[x, b] = null;
                    return true;
                }
                return false;
            }
            else if (currentFish is SmallFish && previosFish is MediumFish)
            {
                if (((MediumFish)previosFish).Eat())
                {
                    sea[x, b] = null;
                    return true;
                }
                return false;
            }
            else
            {
                sea[x + 1, b] = currentFish;
                return true;
            }

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
