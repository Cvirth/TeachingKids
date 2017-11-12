using SmallBasicFun;
using System;
using System.Threading;

namespace TeachingKids._03.HiLow
{
    public class ChooseYourOwnAdventure
    {
        public static void Start()
        {
            startStory();
        }
        private static void startStory()
        {
            tellMoreStory("One morning the Tortoise woke up in a dream.");
           // animateStartStory();
            String action = askAQuestion("Do you want to 'wake up' or 'explore' the dream?");
            if ("wake up".Equals(action, StringComparison.InvariantCultureIgnoreCase)) //"wake up" == action
            {
                WakeUp();
            }
            else if ("explore".Equals(action, StringComparison.InvariantCultureIgnoreCase))
            {
                ApproachOoze();
            }
            else
            {
                EndStory();
            }
        }

        private static void EndStory()
        {
            MessageBox.ShowMessage("You don't know how to read directions. You can't play this game. The end.");
        }

        private static void ApproachOoze()
        {
            MessageBox.ShowMessage("You approach a glowing, green bucket of ooze. Worried that you will get in trouble, you pick up the bucket.");
            String answer = MessageBox.AskForInput("Do you want to pour the ooze into the 'backyard' or 'toilet'?");
            if (answer == "toilet")
            {
                PourIntoToilet();
            }
            else if (answer == "backyard")
            {
                PourIntoBackyard();
            }
            else
            {
                EndStory();
            }
        }

        private static void PourIntoBackyard()
        {
            MessageBox.ShowMessage("As you walk into the backyard a net scoops you up and a giant takes you to a boiling pot of water.");
            string reaction = MessageBox.AskForInput("As the man starts to prepare you as soup, do you...'Scream' or 'Faint'?");
            if (reaction == "Faint")
            {
                MessageBox.ShowMessage("You made a delicious soup! Yum! The end.");
            }
            else if (reaction == "Scream")
            {
                startStory();
            }
            else
            {
                EndStory();
            }
        }

        private static void PourIntoToilet()
        {
            MessageBox.ShowMessage("As you pour the ooze into the toilet it backs up, gurgles, and explodes, covering you in radioactive waste.");
            string ninja = MessageBox.AskForInput("Do you want to train to be a NINJA?  'Yes' or 'HECK YES'?");

            bool isYes = ninja == "Yes";
            bool isHeckYes = ninja == "HECK YES";
            bool is_Yes_or_HeckYes = isYes || isHeckYes;

            if (is_Yes_or_HeckYes)
            //if (ninja == "Yes" || ninja == "HECK YES")
            {
                MessageBox.ShowMessage("Awesome dude!  You live out the rest of your life fighting crimes and eating pizza!");
            }
            else
            {
                EndStory();
            }
        }

        private static void WakeUp()
        {
            MessageBox.ShowMessage("You wake up and have a boring day. The end.");
        }

        private static void animateStartStory()
        {
            Tortoise.Show();
            var color = Colors.Black;
            for (int i = 0; i < 25; i++)
            {
                //Tortoise.getBackgroundWindow().setColor(color);
                color = Colors.Lighten(color);
                Thread.Sleep(100);
            }
        }
        private static void tellMoreStory(String message)
        {
            MessageBox.ShowMessage(message);
        }
        private static String askAQuestion(String question)
        {
            //var anotherVariable = askAQuestion("aaaaaaaaaaa");

            String answer = MessageBox.AskForInput(question);
            return answer;
        }
    }
}
