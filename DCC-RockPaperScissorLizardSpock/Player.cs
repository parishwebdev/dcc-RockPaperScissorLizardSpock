using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_RockPaperScissorLizardSpock
{
    public abstract class Player
    {
        //base class
        string name;
        
        public abstract void MakeChoice(); // on user returns string and correlating int(idx) is returned, computer generates random # return as int; 
        
        // (selection, choices list) and list.Indexof(selection)
    }
}
