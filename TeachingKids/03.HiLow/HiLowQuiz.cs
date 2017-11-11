using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBasicFun;


namespace TeachingKids._03.HiLow
{
    class HiLowQuiz
    {
        public void Question1()
        {
            //  If the Y position of the tortoise is 115
            //  Turn the tortoise to the right 63 degrees 

            var y = Tortoise.GetY();
            if (y == 115)
            {
                Tortoise.Turn(63);
            }

        }

        public void Question2()
        {
            //  If the X position of tortoise is less than Y position of tortoise
            //  Turn the tortoise 54 degrees to the left
            //  Otherwise turn the tortoise 22 degrees to the right

            var x = Tortoise.GetX();
            var y = Tortoise.GetY();
            if (x < y)
            {
                Tortoise.Turn(-54);
            }
            else
            {
                Tortoise.Turn(22);     
            }
        }

        public void Question3()
        {
            //  Display the message "elcomeway omehay!"

            MessageBox.ShowMessage("elcomeway omehay!");
            Console.WriteLine("elcomeway omehay!");
        }

        public void Question4()
        {
            //  If the Y position of tortoise is greater than 50
            //  Turn the tortoise 177 degrees to the left

            var y = Tortoise.GetY();
            if (y > 50)
            {
                Tortoise.Turn(-177);
            }
        }
    }
}
