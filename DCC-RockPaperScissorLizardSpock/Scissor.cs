using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_RockPaperScissorLizardSpock
{
    class Scissor : Choice
    {
        public Scissor(string name)
        {
            this.choiceName = name;
        }
        public override int[] WinAgainst()
        {
            winArray = new int[2] {1,4};
            return winArray;
        }
        public override int[] LoseAgainst()
        {
            loseArray = new int[2] {0,3};
            return loseArray;
        }
    }
}
