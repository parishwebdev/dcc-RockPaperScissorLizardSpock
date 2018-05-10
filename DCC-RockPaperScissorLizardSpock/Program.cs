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
            /*look at rubric
            don't get hung up on abstract/subclass choices*/

            
            Rock r = new Rock("rock");
            Paper p = new Paper("paper");
            List<Choice> choices = new List<Choice>();
            choices.Add(r);
            choices.Add(p);
            
            foreach (Choice c in choices)
            {
                Console.WriteLine(c.choiceName);
                foreach(int j in c.WinAgainst())
                {
                    Console.WriteLine(j);
                }
                
                
            }

            Console.ReadLine();
        }
    }
}
