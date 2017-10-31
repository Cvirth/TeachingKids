using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquare
	{
		public static void Main2()
		{
            var speed = 10;

            Tortoise.Show();

            //Tortoise.SetSpeed(speed);

            var actualSpeed = Tortoise.GetSpeed();
            Tortoise.SetSpeed(actualSpeed + 1);


            speed = 5;

            //Tortoise.SetSpeed(speed);
            
            //Tortoise.SetSpeed(10);
            Tortoise.InstantSpeed(goFast: false);
            // true false
            for (int i = 0; i < 4; i++)
            {
                Tortoise.SetPenColor("#FF00FF");
                Tortoise.Move(lengthInPixels: 50);
                Tortoise.Turn(90);
            }

            

            Fv1(true, "aaa");
		}

        public static void Fv1(bool goFast, string aa2)
        {
            //Tortoise.SetAngle
            Paint.SetSpeed(10);
            //Paint.InstantSpeed(,);
        }
    }

    public class Paint
    {
        public static void Show()
        {

        }
        public static void SetSpeed(int number)
        {

        }

        /// <summary>
        /// Set the speed to be instant or not.
        /// If false, then the Speed ...
        /// </summary>
        /// <param name="goFast">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</param>
        /// <param name="second">bbbbbbbbbbbbbbbbbbbbbbbbbbb</param>
        public static void InstantSpeed(bool goFast, bool second)
        {

        }
    }
}