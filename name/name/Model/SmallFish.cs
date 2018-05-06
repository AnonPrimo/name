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

        public  char N
        {
            get { return n; }
        }

        public SmallFish() { n = 's'; }

        public override string ToString()
        {
            return "Fish: letter - " + n;
        }
    }
}
