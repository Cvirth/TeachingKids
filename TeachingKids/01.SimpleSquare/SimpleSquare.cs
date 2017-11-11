using SmallBasicFun;
using System;

namespace SimpleSquare
{
	public class SimpleSquare
	{
        //public private protected
        public string Blue = "Blue";

		public static void Main2()
		{
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            Tortoise.InstantSpeed(false);
            //var sides = MessageBox.AskForInput("Hány oldal legyen?"); // int - integer - egész szám
            var sides = 25;
            //Tortoise.SetPenColor(Colors.GetRandomColor());
            for (int i = 0; i < sides; i = i+1)
            {
                var color = Colors.GetRandomColor();
                Tortoise.SetPenColor(color); // string - szöveg
                Tortoise.SetPenWidth(i*2);
                Tortoise.Move(i*1.5);
                Tortoise.Turn(-3*360.0/sides);

                //string s1 = 'a'.ToString();
                //char c1 = 'a';

                //string sdf = "" + 3;
                // 360.0 / 13;
                // 360.0 / 13.0;


                //new Random().Next();

                // 360  /13 => int    / int => 27
                // 360.0/13 => double / int => 27.69...

                // 360   - int
                // 360.0 - double
            }
        }

        public static void Fv(int number)
        {

        }

        //public static Primitive Blue;
        //public static Primitive Blue { get; }
    }
}