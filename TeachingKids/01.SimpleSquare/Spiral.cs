using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBasicFun;


namespace SimpleSquare
{
    class Spiral
    {
        public static void Start ()
        {
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            ColorWheel.AddColor(Colors.BlueViolet);
            ColorWheel.AddColor(Colors.Violet);
            ColorWheel.AddColor(Colors.Purple);

            for (int i = 0; i < 75; i++)
            {
                try
                {
                    //var aaa = 100 / i;

                    var nextColor = ColorWheel.GetNextColor();
                    Tortoise.SetPenColor(nextColor);

                    Tortoise.Move((i+1)*5);
                    Tortoise.Turn(360.0 / 3);
                }
                catch (Exception re)
                {
                    MessageBox.ShowMessage("Hold up: " + re);
                }
            }

        }
    }
}
