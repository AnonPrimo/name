using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name.Model
{
    class SaveGame
    {
        static bool MainSaveGame(bool b, SmallFish[,] ar, char keepfish, int col1, int col2)
        {
            bool sg = b;
            if (sg = true)
            {
                SmallFish[,] game = ar;
                char buf = keepfish;
                int fromcol = col1;
                int incol = col2;
            }
            return sg;
        }
    }
}
