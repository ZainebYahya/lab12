using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    abstract class Player
    {


        public string name { set; get; }
        public string roshambovalue { set; get; }
        
        abstract  public string GenerateRoshambo();

    }
}
