using SmallBasicFun;
namespace Houses
{
    public class Houses
    {
        public static void Main2(string[] args)
        {
            Tortoise.SetSpeed(10);
            Tortoise.SetX(200);
            var heigthOfHouse = 40;
            Tortoise.SetPenColor("LightGray");
            DrawHouse(heigthOfHouse);

            heigthOfHouse = 120;
            DrawHouse(heigthOfHouse);

            //DrawHouse(120);
            DrawHouse(90);
            DrawHouse(20);
        }

        private static void DrawHouse(int heigthOfHouse)
        {
            Tortoise.Move(heigthOfHouse);
            Tortoise.Turn(90);
            Tortoise.Move(30);
            Tortoise.Turn(90);
            Tortoise.Move(heigthOfHouse);
            Tortoise.Turn(-90);
            Tortoise.Move(20);
            Tortoise.Turn(-90);
        }

        public static void/*<--output*/ FuggvenyNev(/*input*/)
        {
            // sor
            /*
             sdf
             sdf
             asd
             
             */
        }


    }
}