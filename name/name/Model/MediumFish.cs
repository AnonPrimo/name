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

        public override char N
        {
            get { return n; }
        }
    
        public MediumFish() { n = 'm'; count = 0; }

        public virtual void Eat()
        {
            ++count;
            if (count == 1) n = 'M';
        }


    }
}
