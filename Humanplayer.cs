using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Humanplayer : Player
    {
       
      // public string pick { set; get; }

        public Humanplayer(string humanname,string humanpick)


        {
            name = humanname;
            roshambovalue = humanpick;
        }
        public override string GenerateRoshambo()
        {
            roshambovalue = Console.ReadLine();
            return(roshambovalue);
        }

    }
}
