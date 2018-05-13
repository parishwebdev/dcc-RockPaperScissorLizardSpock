using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DCC_RockPaperScissorLizardSpock
{
     class UserInterface
    {
        public  void OutputText(string param)
        {
            Console.WriteLine(param);
        }
        public string GetUserChoiceInput(string choices, string name)
        {
            Console.WriteLine(name + " choose: " + choices);
            string output = Console.ReadLine();
            if (ValidateChoicesInput(output))
            {
                output = SanitizeOptionInput(output);
                return output;
            }
            return GetUserChoiceInput(choices, name);
        }
        private string SanitizeOptionInput(string input)
        {
            string sanitized = input.ToLower();
            return sanitized;
        }
        private Boolean ValidateChoicesInput(string input)
        {
            string[] acceptedStrings = new string[] { "rock", "paper", "scissor", "spock", "lizard" };
            if (input == "" || input == null)
            {
                OutputText("Please enter a value in: ");
                return false;
            }
            if (int.TryParse(input, out int n))
            {
                OutputText("Please don't enter a number in: ");
                return false;
            }
            if (acceptedStrings.Contains(input) == false)
            {
                OutputText("Please enter the corrert word in: ");
                return false;
            }

            return true;
        }
        public int GetGameTypeInput()
        {
            Console.WriteLine(" Welcome to Rock Paper Scissors Lizard Spock \n Select: \n 1) - Single Player \n 2) - Multiplayer ");
            String gameType = Console.ReadLine();

            if (ValidateGameTypeInput(gameType))
            {
                return int.Parse(gameType);
            }
            return GetGameTypeInput();
            
        }
        private Boolean ValidateGameTypeInput(String input)
        {
            if (input == "" || input == null)
            {
                OutputText("Please enter a value in: ");
                return false;
            }
            if (int.TryParse(input, out int n) == false)
            {
                OutputText("Please enter a number in: ");
                return false;
            }

            return true;
        }
        public string GetNameInput(string message)
        {
            Console.WriteLine("Enter a name " + message);
            string name = Console.ReadLine();
            return name;
        }
        public string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

    }
}
