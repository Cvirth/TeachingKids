using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquareQuiz
	{
		private static void question1()
		{
            Tortoise.Turn(360.0/5);
		}

		private static void question2()
		{
            Tortoise.Move(110);
		}

		private static void question3()
		{
            Tortoise.SetPenColor("yellow");
		}

		private static void question4()
		{
            //  Change the width of the line the tortoise draws to 5 pixels
            Tortoise.SetPenWidth(5);
		}

		#region Ignore

		public static void Main2()
		{
			Quiz.StartSquareQuizAt += question1;
		}

		#endregion
	}
}