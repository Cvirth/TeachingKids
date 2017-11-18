using SmallBasicFun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingKids._04.Mastery
{
    class BackgroundPhoto
    {
        public static void Start()
        {
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            var side = 2;
            for (int i = 0; i < 75; i++)
            {
                //     Set the current pen color to yellow --#6.1
                Tortoise.SetPenColor(Colors.Yellow);
                //     Use the current pen color for the line the tortoise draws --#6.2
                side++;
                Tortoise.Move(side);
                Tortoise.SetX(555);
                Tortoise.SetY(65);
                Tortoise.Turn(360.0 / 3);
                Tortoise.Turn(1);
            }

        }
    }
}
