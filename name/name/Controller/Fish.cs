using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using name.Model;

namespace name.Controller
{
    class Fish
    {
        List<SmallFish> fish = new List<SmallFish>();

        public Fish()
        {
            fish.Add(new SmallFish());
            fish.Add(new MediumFish());
            fish.Add(new BigFish());           
        }

         public Fish(int n)
        {

        }

        

    }
}
