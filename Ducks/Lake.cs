using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Lake
    {
        public string name;
        public int count;
        public int swimming = 0;
        public int hiding = 0;
        public int playing = 0;

        public Lake(string name)
        {
            swimming = 0;
            hiding = 0;
            playing = 0;
        }
    }
}
