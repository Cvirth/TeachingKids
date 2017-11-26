using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBasicFun;

namespace TeachingKids._06.ModelViewController
{
    class AdLibs
    {
        public static void Start()
        {
            var currentAdverb = MessageBox.AskForInput("Enter an adverb!");
            var currentEdVerb = MessageBox.AskForInput("Enter a verb ending in '-ed'.");
            var currentBodyPart = MessageBox.AskForInput("Enter your body part.");
            var currentStory = "Today ";
            currentStory += "I woke " + currentAdverb + ". ";
            currentStory += "Then I " + currentEdVerb + " ";
            currentStory += "my " + currentBodyPart + ". ";
            MessageBox.ShowMessage(currentStory);
        }
    }
}
