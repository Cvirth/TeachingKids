using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBasicFun;


namespace Houses
{
    class TriangleShell
    {
        public static void Main2()
        {
            int length = 1; 
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            for (int i = 0; i < 60; i++)
            {
                DrawTriangle(length);
                Tortoise.SetPenColor(Colors.GetRandomColor());
                length = length + 4;
                Tortoise.Turn(360.0 / 60);
            }
        }

        private static void DrawTriangle(int length)
        {
            for (int i = 0; i < 3; i++)
            {
                Tortoise.Turn(360.0 / 3);
                Tortoise.Move(length);
            }
        }
    }
}
