using SmallBasicFun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingKids._03.HiLow
{
    class ConcentricLoop
    {
        public static void Start()
        {
            Tortoise.Show();
            Tortoise.SetX(150);
            Tortoise.SetY(200);
            //Tortoise.SetSpeed(10);
            Tortoise.InstantSpeed(true);
            for (int i = 0; i < 360; i++)
            {
                Tortoise.Move(3);
                Tortoise.Turn(1);
                if (i % 20 == 0)
                {
                    for (int j = 0; j < 360; j++)
                    {
                        Tortoise.Move(1);
                        Tortoise.Turn(1);
                        Tortoise.SetPenWidth( (j+100) / 100 );
                    }
                }
            }
        }
    }

    // + - / *
    // 10 / 7 = 1
    // 10.0 / 7 = 1.xxx
    // 
    // %
    // 10 % 7 = 3

    // 20 % i == 0
    // i % 20 == 0
}
