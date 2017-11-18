using SmallBasicFun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingKids._04.Mastery
{
    class DigiFlower
    {
        public static void Start()
        {
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            Tortoise.SetPenWidth(3);
            CreateColorPalette();
            for (int i = 0; i < 15; i++)
            {
                DrawOctogon();
                Tortoise.Turn(360.0 / 15);
            }
        }

        private static void DrawOctogon()
        {
            for (int i = 0; i < 8; i++)
            {
                var nextColor = ColorWheel.GetNextColor();
                Tortoise.SetPenColor(nextColor);
                Tortoise.Move(50);
                Tortoise.Turn(360.0 / 8);
            }
        }

        private static void CreateColorPalette()
        {
            var color1 = Colors.Red;
            var color2 = Colors.DarkOrange;
            var color3 = Colors.Gold;
            var color4 = Colors.Yellow;
            ColorWheel.AddColor(color1);
            ColorWheel.AddColor(color2);
            ColorWheel.AddColor(color3);
            ColorWheel.AddColor(color4);
            ColorWheel.AddColor(color4);
            ColorWheel.AddColor(color3);
            ColorWheel.AddColor(color2);
            ColorWheel.AddColor(color1);
        }

        /// <summary>
        /// Kap egy stringet
        /// Megváltoztatja benne az osszes 'b' -t nagy 'B' -re
        /// Ez lesz a visszatérési érték
        /// </summary>
        public static string StringExample(string input)
        {
            // "aaa" -> "aaa"
            // "aba" -> "aBa"

            // andre
            // Andre
            //F3

            var result = "bélának".Replace("béla", "Béla");
            //var result = input.Replace("béla", "Béla");
            return result;
        }
    }
}
