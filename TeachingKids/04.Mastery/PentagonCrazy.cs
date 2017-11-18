using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SmallBasicFun;

namespace TeachingKids._04.Mastery
{
    class PentagonCrazy
    {
        public static void Start()
        {
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            CreateColorPalette();
            DrawPentagon();
        }

        private static void DrawPentagon()
        {
            for (int i = 0; i < 200; i++)
            {
                AdjustPen();
                var length = i;
                Tortoise.Move(length);
                Tortoise.Turn(360.0 / 5);
                Tortoise.Turn(1);
            }
        }

        private static void AdjustPen()
        {
            Tortoise.SetPenColor(ColorWheel.GetNextColor());
            var width = Tortoise.GetPenWidth();
            Tortoise.SetPenWidth(width + 1);
            if (Tortoise.GetPenWidth() > 4)
            {
                Tortoise.SetPenWidth(1);
            }
        }

        private static void CreateColorPalette()
        {
            ColorWheel.AddColor(Colors.SteelBlue);
            ColorWheel.AddColor(Colors.DarkOrchid);
            ColorWheel.AddColor(Colors.DarkSlateBlue);
            ColorWheel.AddColor(Colors.Teal);
            ColorWheel.AddColor(Colors.Indigo);
        }
    }
}
