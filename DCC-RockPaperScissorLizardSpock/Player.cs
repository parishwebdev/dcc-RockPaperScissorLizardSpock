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
        public string name;
        public List<String> choices;

        public abstract String MakeChoice(int numSelection);
    }
}
