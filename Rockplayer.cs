using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Rockplayer : Player

    {
        public Rockplayer()
        {
            name = "rock";
            roshambovalue = "rock";
        }
        public override string GenerateRoshambo()
        {
            return roshambovalue;
        }
    }
}
