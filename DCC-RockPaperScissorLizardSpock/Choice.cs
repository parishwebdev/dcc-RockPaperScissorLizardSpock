using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_RockPaperScissorLizardSpock
{
     public abstract class Choice 
    {
        public string choiceName;
        public int[] winArray;
        public int[] loseArray;

        public abstract int[] WinAgainst();
        public abstract int[] LoseAgainst();
    }
}
