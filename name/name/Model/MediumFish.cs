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
        
    
        public MediumFish() { n = 'm'; count = 0; }

        /// метод Eat() збільшує лічильник рибки і збільшує літеру якщо вона з'їла одну

        public virtual void Eat()
        {
            ++count;
           // if (n == Char.ToUpper(n)) ++count;
            if (count == 1) n = Char.ToUpper(n);
        }

        /// виводимо інформацію про рибку

        public override string ToString()
        {
            return "Fish: letter - " + n + " count - " + count;
        }

    }
}
