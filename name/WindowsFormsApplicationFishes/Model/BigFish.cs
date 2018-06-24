using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationFishes.Model
{
    class BigFish : MediumFish
    {
        public override bool Eat(SmallFish smallFish)
        {
            if (smallFish is BigFish || smallFish is SmallFish)
                return false;
            MediumFish fish = (MediumFish)smallFish;
            if (fish.Count == 1 || this.Count == 1)
                return true;
            this.count++;
            return false;
        }
    }

}
