using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name.Model
{
    class MediumFish : SmallFish
    {
        /// створюємо лічильник, що рахуватиме скільки рибок з'їла данна рибка

        protected int count;

        public virtual int Count
        {
            get { return count; }
        }

        public virtual bool Eat()
        {
            bool b = false;
            ++count;
            if (count == 1) n = Char.ToUpper(n);
            if (count == 2) b = true;
            return b;
        }

        /// виводимо інформацію про рибку

        public override string ToString()
        {
            return "Fish: letter - " + n + " count - " + count;
        }

    }
}
