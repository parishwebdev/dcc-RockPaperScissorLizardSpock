using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_RockPaperScissorLizardSpock
{
    class Computer : Player
    {

        public Computer (string name, List<String> choices,Random rnd) {
            this.name = name;
            this.choices = choices;
        }
        public override string MakeChoice(int numSelection)
        {
            return choices[numSelection];
        }
        public int GenerateComNumSelection(Random rnd)
        {
            int comNumSelection = rnd.Next(0, 5);
            return comNumSelection;
        }

    }
}
