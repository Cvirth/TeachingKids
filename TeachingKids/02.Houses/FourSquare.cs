using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBasicFun;


namespace Houses
{
    class FourSquare
    {
        public static void Main2()
        {
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            for (int i = 0; i < 4; i++)
            {
                DrawSquare();
                Tortoise.Turn(90);
            }
        }

        private static void DrawSquare()
        {
            for (int i = 0; i < 4; i++)
            {
                CreateSide();
            }
        }

        private static void CreateSide()
        {
            Tortoise.SetPenColor(Colors.GetRandomColor());
            Tortoise.Move(50);
            Tortoise.Turn(90);
        }
    }
}
