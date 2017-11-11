using SmallBasicFun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLow
{
    class HiLow
    {
        public static void Start()
        {
            int answerNumber = new Random().Next(1, 100);

            for (int i = 0; i < 8; i++)
            {
                var answer = MessageBox.AskForInput("What is the number? (" + (i + 1) + ". try)");
                // What is the number? (1. try)

                // =     --> Érték adás
                // ==    --> Összehasonlítás

                if (answer == answerNumber)
                {
                    //               Play a bell --#2
                    MessageBox.ShowMessage("You won the game.");
                    return;
                }
                if (answer > answerNumber)
                {
                    MessageBox.ShowMessage("Answer is too high");
                }
                if (answer < answerNumber)
                {
                    MessageBox.ShowMessage("Answer is too low");
                }
            }

            MessageBox.ShowMessage("You lost");
        }

        private static void If1(int answer, int answerNumber)
        {
            if (answer == answerNumber)
            {
                MessageBox.ShowMessage("You won the game.");
                return;
            }
            else
            {
                if (answer > answerNumber)
                {
                    MessageBox.ShowMessage("Answer is too high");
                }
                else
                {
                    if (answer < answerNumber)
                    {
                        MessageBox.ShowMessage("Answer is too low");
                    }
                }
            }
        }

        private static void If12(int answer, int answerNumber)
        {
            if (answer == answerNumber)
            {
                //               Play a bell --#2
                MessageBox.ShowMessage("You won the game.");
                return;
            }
            else if (answer > answerNumber)
            {
                MessageBox.ShowMessage("Answer is too high");
            }
            else if (answer < answerNumber)
            {
                MessageBox.ShowMessage("Answer is too low");
            }
        }
    }
}
