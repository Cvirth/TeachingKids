using SmallBasicFun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingKids._04.Mastery
{
    class PentagonCrazyQuiz
    {
        public void Question1()
        {
            CreateAStitch();
        }

        private static void CreateAStitch()
        {
            Tortoise.Move(6);
        }

        public void Question2()
        {
            for (int i = 0; i < 76; i++)
            {
                CreateAStitch();
            }
        }

        public void Question3()
        {
            ColorWheel.AddColor("lime");
        }

        public void Question4()
        {
            ColorWheel.AddColor(Colors.Red);
        }

    }
}
