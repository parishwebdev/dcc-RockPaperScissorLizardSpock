using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_RockPaperScissorLizardSpock
{
    class UserInterface
    {
        public void OutputText(string param)
        {
            Console.WriteLine(param);
        }

        public string GetUserChoiceInput(string choices)
        {
            Console.WriteLine("Choose: " + choices);
            string output = Console.ReadLine();
            return output;

        }

    }
}
