using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_RockPaperScissorLizardSpock
{
    class Game 
    {
        public User user1;
        public User user2;
        public Computer comp;
        public Random rnd;
        public UserInterface ui;

        public List<String> choices;


        public Game()
        {
            ui = new UserInterface();
            rnd = new Random();
            CreateChoices();

        }

        public bool EvaluateGameType(int typeInput)
        {
            bool result = false;

            if (typeInput == 2)
            {
                //MultiPlayer(user1,user2);
                 result = true;
            }
            else if (typeInput == 1)
            {
                //SinglePlayer(user1,comp);
                 result = false;
            }
            return result;
        }

        //later add param for name(s)
        public void SinglePlayer(User user1, Computer comp, string name1)
        {
            this.user1 = new User(name1,choices);
            this.comp = new Computer("Jarvis", choices,rnd);
        }
        //later add param for name(s)
        public void MultiPlayer(User user1, User user2,string name1,string name2)
        {
            this.user1 = new User(name1, choices); 
            this.user2 = new User(name2, choices);
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
            for(int i = 0; i < choices.Count;i++)
            {
                if (choices.Count() - 1 == i)
                {
                    choiceNames += choices[i];
                }
                else
                {
                    choiceNames += choices[i] + ", ";
                }
            }

            return choiceNames;
        }

        public int CompareAnswersDiff(string c1, string c2)
        {
            int a = choices.IndexOf(c1);
            int b = choices.IndexOf(c2);
            int d = (5 + a - b) % 5;
            return d;
        }
        public void FindRoundWinner(int d, string c1, string c2, Player p1, Player p2)
        {
            if (d == 1 || d == 3)
            {
                ui.OutputText(p1.name + " wins the round. " + ui.UppercaseFirst(c1) + " defeats " + c2);
                p1.score++;
            }
            else if (d == 2 || d == 4)
            {
                ui.OutputText(p2.name + " wins the round. " + ui.UppercaseFirst(c2) + " defeats " + c1);
                p2.score++;
            }
            else if (d == 0)
            {
                ui.OutputText("Tie for this round. No points gained");
            }
        }
        public void DisplayScoreBoard(Player p1, Player p2)
        {
            ui.OutputText(p1.name + "'s score: " + p1.score + "\n" + p2.name + "'s score: " + p2.score);
        }
        public void DisplayGameWinner(Player p1, Player p2)
        {
            if(p1.score == 3)
            {
                ui.OutputText("\n" + p1.name + " wins the game");
            }
            else if (p2.score == 3)
            {
                ui.OutputText("\n" + p2.name + " wins the game");
            }
        }


    }
}
