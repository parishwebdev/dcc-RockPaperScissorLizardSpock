using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_RockPaperScissorLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();

            int gametype = g.ui.GetGameTypeInput();

            if (g.EvaluateGameType(gametype)){
                string name1 = g.ui.GetNameInput("for player one: ");
                string name2 = g.ui.GetNameInput("for player two: ");
                g.MultiPlayer(g.user1,g.user2,name1,name2);

                while(g.user1.score < 3 && g.user2.score < 3)
                {
                    string selection1 = g.ui.GetUserChoiceInput(g.GetChoiceNamesAsString(g.choices),g.user1.name);
                    string selection2 = g.ui.GetUserChoiceInput(g.GetChoiceNamesAsString(g.choices),g.user2.name);
                    string user1Choice = g.user1.MakeChoice(g.user1.ConvertStringChoiceToNumSelection(selection1));
                    string user2Choice = g.user2.MakeChoice(g.user2.ConvertStringChoiceToNumSelection(selection2));
                    int diff = g.CompareAnswersDiff(user1Choice, user2Choice);
                    g.FindRoundWinner(diff,user1Choice,user2Choice,g.user1,g.user2);
                    g.DisplayScoreBoard(g.user1, g.user2);
                }
                g.DisplayGameWinner(g.user1,g.user2);
            }
            else
            {
                string name = g.ui.GetNameInput("for yourself: ");
                g.SinglePlayer(g.user1,g.comp,name);
                while (g.user1.score < 3 && g.comp.score < 3)
                {
                    string selection1 = g.ui.GetUserChoiceInput(g.GetChoiceNamesAsString(g.choices), g.user1.name);
                    string user2Choice = g.comp.MakeChoice(g.comp.GenerateComNumSelection(g.rnd));
                    string user1Choice = g.user1.MakeChoice(g.user1.ConvertStringChoiceToNumSelection(selection1));
                    int diff = g.CompareAnswersDiff(user1Choice, user2Choice);
                    g.FindRoundWinner(diff, user1Choice, user2Choice, g.user1, g.comp);
                    g.DisplayScoreBoard(g.user1, g.comp);
                }
                g.DisplayGameWinner(g.user1, g.comp);
            }

            Console.ReadLine();
        }
    }
}
