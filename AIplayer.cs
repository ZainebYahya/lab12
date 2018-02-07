using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class AIplayer : Player
    {
        Random random = new Random();

        public AIplayer()
        {
            name = "AIplayer";

        }

        public override string GenerateRoshambo()
        {
            System.Threading.Thread.Sleep(50);
            

            int num = random.Next(1, 4);
            if (num == 1) { roshambovalue = "scissors"; }
            else if (num == 2) { roshambovalue = "paper"; }
            else if (num == 3) roshambovalue = "rock";
            return roshambovalue;
        }
    }
        
}
