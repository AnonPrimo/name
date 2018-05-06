using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name.View
{
    class mainView
    {
        public void StartGame()
        {
            Console.WriteLine("\tGAME FISH");
            Level l = new Level();
            l.StartLevel1();
        }
    }
}
