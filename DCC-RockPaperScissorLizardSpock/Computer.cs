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
            return "";
        }
        public int GenerateComNumSelection()
        {
            Random rnd = new Random();
            int comNumSelection = rnd.Next(0, 4);
            return comNumSelection;
        }

    }
}
