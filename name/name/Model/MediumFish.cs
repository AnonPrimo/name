using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name.Model
{
    class MediumFish : SmallFish
    {
        protected int count;

        public virtual int Count
        {
            get { return count; }
        }
        
    
        public MediumFish() { n = 'm'; count = 0; }

        public virtual void Eat()
        {
            ++count;
            if (n == Char.ToUpper(n)) ++count;
            if (count == 1) n = Char.ToUpper(n);
        }

        public override string ToString()
        {
            return "Fish: letter - " + n + " count - " + count;
        }

    }
}
