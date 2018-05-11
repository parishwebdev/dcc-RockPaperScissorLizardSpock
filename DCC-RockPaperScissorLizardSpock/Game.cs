using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_RockPaperScissorLizardSpock
{
    class Game 
    {
        User user1;
        User user2;
        Computer comp;
        Random rnd;

        List<String> choices;
        int roundNumber;


        public Game()
        {
            //ui to sin or multi
            //ui for name(s) (here?)
            rnd = new Random();
            CreateChoices();

        }

        public void SinglePlayer()
        {
            user1 = new User("namefromInput",choices);
            comp = new Computer("Javis", choices,rnd);
        }
        public void MultiPlayer()
        {
            user1 = new User("namefromInput", choices); //differnt variable (like p1,p2)
            user2 = new User("namefromInput", choices);
        }
        public void CreateChoices()
        {
            choices = new List<String>();

            choices.Add("rock"); //0
            choices.Add("paper"); //1
            choices.Add("scissor"); //2
            choices.Add("spock"); //3
            choices.Add("lizard"); //4
        }

        public string GetChoiceNamesAsString(List<String> choices){
            
            string choiceNames = "";
            foreach(String c in choices)
            {
                choiceNames +=  c[0] +  ", " ;
            }

            return choiceNames;
        }

        public void GetRoundWinner(string c1, string c2)
        {

        }

    }
}
