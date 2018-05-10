using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_RockPaperScissorLizardSpock
{
    class Rock : Choice
    {

        public Rock(string name)
        {
            this.choiceName = name;
        }
        public override int[] WinAgainst()
        {
            winArray = new int[2]{2,4};
            return winArray;
        }
        public override int[] LoseAgainst()
        {
            loseArray = new int[2] {3,1};
            return winArray;
        }
    }
}
