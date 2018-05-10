using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_RockPaperScissorLizardSpock
{
    class Game //where main or here...
    {
        Rock r;
        Paper p;
        Scissor sc;
        Lizard l;
        Spock sp;

        //ui class (here?)
        List<Choice> choices = new List<Choice>();
        int roundNumber;


        public Game()
        {

        }

        public void SinglePlayer()
        {
            //new User();
            //new Computer;
        }
        public void MultiPlayer()
        {
            //new User(); //differnt variable (like p1,p2)
            //new User();
        }
        public void CreateChoices()
        {
            r = new Rock("rock");
            p = new Paper("paper");
            sc = new Scissor("scissor");
            l = new Lizard("lizard");
            sp = new Spock("spock");
        }
        public void PopulateChoiceList()
        {
            choices.Add(r); //0
            choices.Add(p); //1
            choices.Add(sc); //2
            choices.Add(sp); //3
            choices.Add(l); //4
        }
        public string GetChoiceNamesAsString(){

            string choiceNames = "";
            foreach(Choice c in choices)
            {
                choiceNames +=  c.choiceName +  ", " ;
            }

            return choiceNames;
        }
    }
}
