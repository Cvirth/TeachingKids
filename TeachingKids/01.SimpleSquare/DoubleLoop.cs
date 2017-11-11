using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBasicFun;


namespace SimpleSquare
{
    class DoubleLoop
    {
        public static void Start()
        {
            Tortoise.Show();
            Tortoise.Hide();
            Tortoise.SetX(225);
            Tortoise.SetY(150);

            Tortoise.SetSpeed(10);
            ColorWheel.AddColor(Colors.Crimson);
            ColorWheel.AddColor(Colors.DarkRed);
            ColorWheel.AddColor(Colors.FireBrick);
            for (int i = 0; i < 6; i++)
            {
                Tortoise.SetPenColor(ColorWheel.GetNextColor());
                Tortoise.Move((i+1)*4);
                Tortoise.Turn(-360.0 / 6);
                for (int j = 0; j < 15; j++)
                {
                    Tortoise.SetPenWidth(17);
                    Tortoise.Move((j+1)*8);
                    Tortoise.Turn(360.0 / 5);
                }

                //--Tortoise.getBackgroundWindow().setBackground(PenColors.Yellows.PeachPuff);
            }

            Tortoise.SetX(300);
            Tortoise.SetY(200);
            for (int i = 0; i < 5; i++)
            {
                Tortoise.SetPenColor("Black");
                Tortoise.Move(25);
                Tortoise.Turn(360.0 / 5);
            }
           
        }
    }
}
