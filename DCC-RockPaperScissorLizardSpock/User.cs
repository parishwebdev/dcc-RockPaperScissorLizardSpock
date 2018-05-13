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
            return choices[numSelection];
        }
        public int ConvertStringChoiceToNumSelection(string selection)
        {
            int output = -1;
            switch (selection)
            {
                case "rock":
                    output = 0;
                break;
                case "paper":
                    output = 1;
                break;
                case "scissor":
                    output = 2;
                break;
                case "spock":
                    output = 3;
                break;
                case "lizard":
                    output = 4;
                break;
                default:
                    Console.WriteLine("Wrong Selection");
                break;
            }

            return output;
        }
    }
}
