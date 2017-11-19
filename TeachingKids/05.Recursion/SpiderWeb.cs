using SmallBasicFun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingKids._05.Recursion
{
    class SpiderWeb
    {
        public static void Start()
        {
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            Tortoise.SetPenWidth(1);
            Tortoise.SetPenColor("black");
            var lineLength = 10.5;
            var zoom = 1.1;
            for (int i = 0; i < 10; i++)
            {
                WeaveOneLayer(lineLength, zoom);
                zoom = zoom * 1.3;
            }
        }
        public static void WeaveOneLayer(double lineLength, double zoom)
        {
            lineLength = lineLength + zoom;
            for (int i = 0; i < 6; i++)
            {
                DrawTriangle(lineLength);
                Tortoise.Turn(360.0 / 6);
                //lineLength = lineLength + zoom;
            }
        }
        public static void DrawTriangle(double lineLength)
        {
            Console.WriteLine(lineLength);

            for (int i = 0; i < 3; i++)
            {
                Tortoise.Move(lineLength);
                Tortoise.Turn(360.0 / 3);
                
            }
        }
    }
}
