using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name.Model
{
    class BigFish : MediumFish
    {

        public BigFish() { n = 'b'; count = 0; }

        /// виводимо інформацію про рибку

        public override string ToString()
        {
            return "Fish: letter - " + n + " count - " + count;
        }

    }

}
