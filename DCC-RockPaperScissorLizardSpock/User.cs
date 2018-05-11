using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_RockPaperScissorLizardSpock
{
    class User : Player
    {

        public User(string name, List<String> choices)
        {
            this.name = name;
            this.choices = choices;
        }

        public override string MakeChoice(int numSelection)
        {
            return choices[2];
        }
        public void ConvertStringChoiceToNumSelection(string selection)
        {

        }
    }
}
