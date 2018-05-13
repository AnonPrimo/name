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
        SmallFish[,] sea;

        SmallFish currentFish;
        private int rows;
        private int cols;
        private int Counter;

        View.Level level = new View.Level();        

        public void find(int a)
        {
            currentFish = null;
            if (a >= sea.GetLength(1))
                return;
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
            if(x >= sea.GetLength(0))
                return -1;
            for (int i = sea.GetLength(0) - 1; i >= 0; i--)
                if (sea[i, x] != null)
                    return i;
            return -1;
        }


        private bool Position(out SmallFish f, out int x, int b)
        {
            f = null;
            x = isFish(b);
            if (x + 1 >= sea.GetLength(0))
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
            level.ShowFishes(sea);
        }
        public bool push(int b)
        {
            if (currentFish == null) return false;


            int x;
            SmallFish previosFish;
            if (!Position(out previosFish, out x, b))
                return false;

            if (!(currentFish is BigFish) && currentFish is MediumFish && previosFish is BigFish )
            {
                if (((BigFish)previosFish).Eat() || ((MediumFish)currentFish).Count == 1)
                {
                    sea[x, b] = null;
                    return true;
                }
                currentFish = null;
                return false;
            }
            else if (!(currentFish is MediumFish) && !(previosFish is BigFish) && (previosFish is MediumFish))
            {
                if (((MediumFish)previosFish).Eat())
                {
                    sea[x, b] = null;
                    return true;
                }
                currentFish = null;
                return false;
            }
            else
            {
                sea[x + 1, b] = currentFish;
                currentFish = null;
                return true;
            }

        }

        public SeaClass(int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;
            sea = new SmallFish[rows, cols]; // ініціалізація розмірнсті.

            //for (int i = 0; i < rows; i++) // Заповнення null.
            //    for (int j = 0; j < cols; j++)
            //        sea[i, j] = null;

            StartNewLevel(0, new SmallFish[,] {
               { new SmallFish(),   new MediumFish(),   new BigFish() },
               { null,              null,               null},
               { null,              null,               null}
            });
            this.StartGame();
        }

        private void StartGame()
        {
            while (true)
            {
                level.RefreshConsole(sea);
                Console.WriteLine("Взяти рибку");
                int index1 = level.GetIndexFindFish();
                this.find(index1);
                if (currentFish == null)
                    continue;
                level.RefreshConsole(sea);
                int index2 = level.GetIndexFindFish();
                if (!this.push(index2))
                {
                    this.push(index1);
                    continue;
                }
            }
        }

    }
}
