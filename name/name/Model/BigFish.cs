using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name.Model
{
    class BigFish : MediumFish
    {
        public override int Count
        {
            get { return count; }
        }

        public override char N
        {
            get { return n; }
        }

        public BigFish() { n = 'b'; count = 0; }

        public override void Eat()
        {
            ++count;
            if (count == 1) n = 'B';
        }

    }

}
