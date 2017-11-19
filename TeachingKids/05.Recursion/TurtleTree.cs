using SmallBasicFun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingKids._05.Recursion
{
    class TurtleTree
    {
        public static void Start()
        {
            Tortoise.Show();
            Tortoise.SetSpeed(10);
            var currentBranchLength = 60;
            DrawBranch(currentBranchLength);
        }

        private static void DrawBranch(int currentBranchLength)
        {
            if (currentBranchLength > 0)
            {
                AdjustColor(currentBranchLength);
                Tortoise.Move(currentBranchLength);
                DrawLowerBranches(currentBranchLength);
            }
        }

        private static void AdjustColor_WithIfs(int currentBranchLength)
        {
            if (currentBranchLength == 60)
            {
                Tortoise.SetPenColor(Colors.SaddleBrown);
            }
            //...
        }

        private static void AdjustColor(int currentBranchLength)
        {
            var colors = new Dictionary<int, string>();
            colors.Add(10, Colors.Lime);
            colors.Add(20, Colors.ForestGreen);
            colors.Add(30, Colors.DarkGreen);
            colors.Add(40, Colors.Olive);
            colors.Add(50, Colors.Sienna);
            colors.Add(60, Colors.SaddleBrown);

            Tortoise.SetPenColor(colors[currentBranchLength]);
        }

        private static void DrawLowerBranches(int currentBranchLength)
        {
            Tortoise.Turn(30);
            DrawShorterBranch(currentBranchLength);
            Tortoise.Turn(-60);
            DrawShorterBranch(currentBranchLength);
            Tortoise.Turn(30);
            AdjustColor(currentBranchLength);
            Tortoise.Move(-currentBranchLength);
        }

        private static void DrawShorterBranch(int currentBranchLength)
        {
            DrawBranch(currentBranchLength - 10);
        }

        /*
            var colors = new Dictionary<int, string>();

            colors.Add(1, "Valami");
            colors.Add(2, "Valami más");

            //colors[1] == "Valami"
            //colors[2] == "Valami más"

            string aa = colors[1];
         */
    }
}
