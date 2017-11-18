using SmallBasicFun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingKids._04.Mastery
{
    class KnottedRing
    {
        public static void Start()
        {
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            CreateColorPalette();
            for (int i = 0; i < 30; i++)
            {
                var nextColor = ColorWheel.GetNextColor();
                Tortoise.SetPenColor(nextColor);
                DrawOctagonWithOverlap();
                Tortoise.Turn(360.0 / 30);
                Tortoise.Turn(5);
            }

        }

        private static void DrawOctagonWithOverlap()
        {
            for (int i = 0; i < 8 + 1; i++)
            {
                Tortoise.Move(110);
                Tortoise.Turn(360.0 / 8);
            }
        }

        private static void CreateColorPalette()
        {
            ColorWheel.AddColor(Colors.HotPink);
            ColorWheel.AddColor(Colors.Red);
            ColorWheel.AddColor(Colors.Fuchsia);
            ColorWheel.AddColor(Colors.OrangeRed);
            ColorWheel.AddColor(Colors.DeepPink);
            ColorWheel.AddColor(Colors.MediumVioletRed);
            ColorWheel.AddColor(Colors.Crimson);
            ColorWheel.AddColor(Colors.Tomato);
        }
    }
}
