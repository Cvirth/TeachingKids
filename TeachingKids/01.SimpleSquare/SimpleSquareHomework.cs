using System;
using Microsoft.SmallBasic.Library;
using SmallBasicFun;

namespace SimpleSquare
{
    public class SimpleSquareHomework
	{
        // How to do homework:
        // Step 1: Press the Run Button (Ctrl+F5)
        // Step 2: Read the name of the Method that Failed
        // Step 3: Fill in the blank (___) to make it pass
        // Step 4: Repeat Until Enlightment
        // Do not change anything except the blank (___)

       // public static int topspeed3 = 10;

		private static void numbersdonotneedquotes()
		{
			Homework.CheckAnswer(42, equals, 42);
		}

		private static void defaultwidthforthetortoise()
		{
			Homework.CheckAnswer(2 , equals, Tortoise.GetPenWidth());
		}

		private static void stringsneedquotes()
		{
            //var color = Colors.Green;
            // Homework.CheckAnswer(color , equals, "Green");
            Homework.CheckAnswer("Green" , equals, "Green");
        }

        private static void stringscanincludespaces()
		{
			Homework.CheckAnswer("This is a string", equals, "This is a string");
		}

		private static void defaultcolorforthetortoise()
		{
			Homework.CheckAnswer("Black", equals, Tortoise.GetPenColor());
		}

		private static void changingthepenwidthto5()
		{
			Tortoise.SetPenWidth(5);
			Homework.CheckAnswer(5, equals, Tortoise.GetPenWidth());
		}

		private static void changingthepencolortogreen()
		{
			Tortoise.SetPenColor("Green");
			Homework.CheckAnswer(Tortoise.GetPenColor(), equals, "Green");
		}

		private static void movingthetortoise100pixels()
		{
			var start = Tortoise.GetY(); //240
			Tortoise.Move(100); //
            var end = Tortoise.GetY();
			Homework.CheckAnswer(start - 100, equals, Tortoise.GetY());
		}

		private static void thetortoiseturns21()
		{
            Tortoise.Turn(21);
            Homework.CheckAnswer(21, equals, Tortoise.GetAngle());
		}

		private static void thetortoiseturns15twice()
		{
			var ans = 15;
			Tortoise.Turn(ans);
			Tortoise.Turn(ans);
			Homework.CheckAnswer(30, equals, Tortoise.GetAngle());
		}

		private static void howfastcanthetortoisego()
		{
			Tortoise.SetSpeed(10);
			Homework.CheckAnswer(topSpeed, equals, Tortoise.GetSpeed());
			//Hint: Right Click SetSpeed then select 'Go to Declaration' 
		}

        private static void assigningvariables()
		{
			Primitive numberOfToes = 10;
			Homework.CheckAnswer(10, equals, numberOfToes);
		}

		private static void combiningnumbers()
		{
			Primitive age = 3 + 4;
			Homework.CheckAnswer(7, equals, age);
		}

		private static void combiningtext()
		{
            //string string1 = "Peter";
            //string string2 = 333.ToString();

            //Primitive a1 = Tortoise.GetPenColor();
            //var a2 = a1.ToString();

            //int b1 = 111;
            //string b2 = b1.ToString(); // "111"


            //string combined = string1 + string2; // "Peter333"

            Primitive name = "Peter" + " " + "Pan";
			Homework.CheckAnswer("Peter Pan", equals, name);
		}

		private static void combiningtextandnumbers()
		{
            string aaa = "" + "";
            int bbb = 111 + 222; // 333
            var ccc = "111" + 222.ToString(); // "111222"

			Primitive name = "Henry The " + 8;
			Homework.CheckAnswer("Henry The 8", equals, name);
		}

		private static void combiningtextinaloop()
		{
			Primitive sound = "A";
			for (int i = 1; i <= 3; i++)
			{
				sound = sound + "H";
			}
			Homework.CheckAnswer("AHHH", equals, sound);
		}

		private static void forloopsendattheend()
		{
			Primitive numbers = "@";
			for (int i = 1; i <= 5; i++)
			{
				numbers = numbers + i;
			}
			Homework.CheckAnswer(numbers, equals, "@12345");
		}

		private static void forloopscanstartanywhere()
		{
			Primitive answer = "Because ";
			for (int i = 7; i <= 9; i++)
			{
				answer = answer + i;
			}
			//Question: Why is 7 the most feared number ?
			Homework.CheckAnswer(answer, equals, "Because 789");
		}

		private static void forloopscanskip()
		{
            // i++ -> i = i + 1; --> i += 1;

			Primitive numbers = "@";
			for (int i = 1; i <= 20; i += 2)
			{
				PreventInfiniteLoop();
				numbers = numbers + i + ",";
			}
			Homework.CheckAnswer(numbers, equals, "@1,3,5,7,9,11,13,15,17,19,");
		}

		private static void forloopscangobackwards()
		{
			Primitive numbers = "Countdown: ";
			for (int i = 5; i >= 1; i += -1)
			{
				PreventInfiniteLoop();
				numbers = numbers + i;
			}
			Homework.CheckAnswer(numbers, equals, "Countdown: 54321");
		}

		#region Ignore

		public static void Main2()
		{
			Homework.StartSimpleSquareHomeworkAt += numbersdonotneedquotes;
		}
		private static void PreventInfiniteLoop()
		{
			if (infiniteLoopCount++ > 4000)
			{
				throw new Exception("You have created an infinite loop.");
			}
		}

		private static readonly Primitive ___ = "Fill in the blank ___";
		private static readonly Primitive ____ = 1;

		private static readonly Primitive topSpeed = 10;
		private static readonly Primitive equals = "=";
		private static int infiniteLoopCount = 0;

		#endregion
	}
}