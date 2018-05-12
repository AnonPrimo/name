using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name.Model
{
    class SmallFish
    {
        /// створюємо змінну яка міститиме тип рибки

        protected char n;

        public  char N
        {
            get { return n; }
        }

        public SmallFish() { n = 's'; }
        
        /// виводимо інформацію про рибку

        public override string ToString()
        {
            return "Fish: letter - " + n;
        }
    }
}
