using Microsoft.SmallBasic.Library;
using SmallBasicFun;

namespace Houses
{
    public class HousesQuiz
    {
        private static Primitive length = 0;

        private static void question1()
        {
            //The current length is 7
            length = 7;
        }

        //Question2
        //Create a subroutine called medium
        //    that sets the current length to 21
        private static void medium()
        {
            length = 21;
        }


        //Question3
        //Create a subroutine called large
        //    that sets the current length to 63
        private static void large()
        {
            length = 63;
        }


        //Question4
        //Create a subroutine called movethelength
        //    that moves the Tortoise the current length
        private static void movethelength()
        {
            Tortoise.Move(length);
        }


        //Question5
        //Create a subroutine called turnthecorner
        //    that turns the Tortoise 1/3 of 360 degrees to the left
        private static void turnthecorner()
        {
            Tortoise.Turn(-360.0 / 3);
        }


        //Question6
        //Create a subroutine called drawaside
        //    that calls movethelength and turnthecorner
        private static void drawaside()
        {
            movethelength();
            turnthecorner();
        }

        #region Ignore

        public static void Main2()
		{
			Quiz.StartHouseQuizAt += question1;
		}

		#endregion
	}
}