using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name.Model
{
    class SmallFish
    {
        protected char n;

        public virtual char N
        {
            get { return n; }
        }

        public SmallFish() { n = 's'; }
    }
}
