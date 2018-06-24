using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationFishes.Model
{
    class MediumFish : SmallFish
    {
        /// створюємо лічильник, що рахуватиме скільки рибок з'їла данна рибка

        protected int count;

        public virtual int Count
        {
            get { return count; }
        }

        public virtual bool Eat(SmallFish smallFish)
        {
            if (!(smallFish is SmallFish))
                return false;
            bool b = false;
            ++count;
            //if (count == 1) n = Char.ToUpper(n); // Присвоїти нову картинку.
            //if (count == 2) b = true;
            return b;
        }
    }
}
