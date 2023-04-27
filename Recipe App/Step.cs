using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_App
{
    internal class Steps
    {
       public string Step { get; set; }

       //array to hold steps for recipe
       public string[] listOfSteps;
        public Steps() { listOfSteps = new string[0]; }
       
        public Steps(string step) 
        {
            step = Step;
            listOfSteps = new string[0];
        }

        //method to add step to array
        public void addStep(int i, string step)
        {
            listOfSteps[i] = step;
        }

        //method to clear array of steps
        public void clearSteps()
        {
            Array.Clear(listOfSteps, 0, listOfSteps.Length);
        }

        //method to return specific step
        public string displaySteps(int index)
        {
            return listOfSteps[index];
        }
    }
}
