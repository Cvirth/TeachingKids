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
            var y = Tortoise.GetY();
            if (y == 115)
            {
                Tortoise.Turn(63);
            }

        }

        public void Question2()
        {
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
            MessageBox.ShowMessage("elcomeway omehay!");
            Console.WriteLine("elcomeway omehay!");
        }

        public void Question4()
        {
            //  If the Y position of tortoise is greater than 50
            var y = Tortoise.GetY();
            if (y > 50)
            {
                Tortoise.Turn(-177);
            }
            //  Turn the tortoise 177 degrees to the left
        }
    }
}
