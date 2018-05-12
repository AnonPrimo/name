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
       
        public SeaClass()
        {
            //random sea generation
        }

        /// <summary>
        /// Знаходження риби в масиві, переносення її в currentFish
        /// </summary>
        /// <param name="a">номер стопчика</param>
        public void find(int a)
        {
            currentFish = null;
            for (int i = (int)Math.Sqrt(sea.Length) - 1; i >= 0; i--)
            {
                if (sea[i, a] != null)
                {
                   currentFish = sea[i, a];
                    sea[i, a] = null;
                    break;
                }
            }
        }

        /// <summary>
        /// Перевірка наявності риби в стопчику
        /// </summary>
        /// <param name="x">індекс стопчика</param>
        /// <returns>індекс рядки або -1</returns>
        public int isFish(int x)
        {
            for (int i = (int)Math.Sqrt(sea.Length) - 1; i >= 0; i--)
                if (sea[i, x] != null)
                    return i;
            return -1;
        }

        /// <summary>
        /// Перевірка позиції 
        /// </summary>
        /// <param name="f">попередня риба в данному стопчику</param>
        /// <param name="x">індекс рядка попередньої риби</param>
        /// <param name="b">індекс стопчика</param>
        /// <returns>false - неможливо добавити рибу, true - можна добавити в стопчик</returns>
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

        /// <summary>
        /// Переносить поточну рибу в інший стопчик або скормлює іншій рибі
        /// </summary>
        /// <param name="b">індекс стопчика</param>
        /// <returns>true - вдалось перенести або скормити, false - помилка</returns>
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
       
        
    }
}
