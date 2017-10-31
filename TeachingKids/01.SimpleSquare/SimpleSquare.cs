using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquare
	{
		public static void Main2()
		{
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            Tortoise.InstantSpeed(goFast: false);
            // true false
            for (int i = 0; i < 4; i++)
            {
                Tortoise.SetPenColor(color: "blue");
                Tortoise.Move(lengthInPixels: 50);
                Tortoise.Turn(degrees: 90);
            }

            Fv1(true, "aaa");
		}

        public static void Fv1(bool goFast, string aa2)
        {

        }
    }
}