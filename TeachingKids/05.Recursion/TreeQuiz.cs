using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingKids._05.Recursion
{

    class TreeQuiz
    {
        public void Questions1To4()
        {
            var currentLength = 10;
            var turn = 5;
            var angles = new Dictionary<int, int>();

            //   Question 1 
            currentLength = DoubleLength(currentLength);

            //   Question 2 
            turn = DecreaseTurn(turn);

            //   Question 3 
            angles = SetNinety(angles, turn);

            //   Question 4 
            angles  = AngleFive(angles);
        }

        private static Dictionary<int,int> AngleFive(Dictionary<int, int> angles)
        {
            angles.Add(5, 36);
            return angles;
        }

        private static Dictionary<int, int>  SetNinety(Dictionary<int, int> angles, int turn)
        {
            angles.Add(turn, 90);
            return angles;
        }
        private static int DecreaseTurn(int decrease)
        {
            decrease -= 1;
            return decrease;
        }

        //private static void DecreaseTurn2(int decrease)
        //{
        //    decrease -= 1;
        //}

        private static int DoubleLength(int currentLength)
        {
            currentLength = currentLength * 2;
            return currentLength;
        }
    }
}
