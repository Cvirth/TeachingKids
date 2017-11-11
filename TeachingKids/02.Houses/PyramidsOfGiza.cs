using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBasicFun;


namespace TeachingKids._02.Houses
{
    class PyramidsOfGiza
    {
        public static void Main2(String[] args)
        {
            setUpPyramidLand();
            Tortoise.Turn(-90);
            Tortoise.Move(220);
            Tortoise.Turn(+135);
            Tortoise.Move(100);
            Tortoise.Turn(90);
            Tortoise.Move(100);
            Tortoise.Turn(-90);
            Tortoise.Move(100);
            Tortoise.Turn(+90);
            Tortoise.Move(100);
            Tortoise.Turn(-90);
            Tortoise.Move(100);
            Tortoise.Turn(+90);
            Tortoise.Move(100);
            Tortoise.Turn(+135);
            Tortoise.Move(210);
        }
        private static void setUpPyramidLand()
        {
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            //Tortoise.GetBackgroundWindow().setBackground(Colors.AliceBlue);
            Tortoise.SetPenColor(Colors.DarkGoldenrod);
            Tortoise.SetPenWidth(2);
            Tortoise.Hide();
        }
    }
}
