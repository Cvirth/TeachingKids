using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBasicFun;

namespace TeachingKids._05.Recursion
{
    class RecursiveSquare
    {
        public static void Start()
        {
            Tortoise.Show();
            Tortoise.SetPenColor(Colors.Gold);
            Tortoise.SetSpeed(10);
            double length = 100.0;
            MakeASquare(length);
        }

        private static void MoveBackToCenter(double length)
        {
            Tortoise.PenUp();
            Tortoise.Turn(90);
            Tortoise.Move(length / 2);
            Tortoise.Turn(90);
            Tortoise.Move(length / 2);
            Tortoise.Turn(180);
            Tortoise.PenDown();
        }

        private static void MoveToTheSquareStart(double length)
        {
            Tortoise.PenUp();
            Tortoise.Move(length / 2);
            Tortoise.Turn(-90);
            Tortoise.Move(length / 2);
            Tortoise.Turn(180);
            Tortoise.PenDown();
        }

        private static void MakeASquare(double length)
        {

            if (length > 10)
            {
                MoveToTheSquareStart(length);


                for (int i = 0; i < 4; i++)
                {
                    Tortoise.Move(length);
                    var newLength = length / 1.7;
                    MakeASquare(newLength);

                    if (i < 3)
                    {
                        Tortoise.Turn(90);
                    }
                }

                MoveBackToCenter(length);
                length *= 2;
            }
        }
    }
}