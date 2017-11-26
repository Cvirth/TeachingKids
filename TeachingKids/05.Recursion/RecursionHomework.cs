using System;
using System.Collections.Generic;
using Microsoft.SmallBasic.Library;
using SmallBasicFun;

namespace TeachingKids._05.Recursion
{
    class RecursionHomework
    {
        //  Step 1: SELECT the method name (changeThePointerToAHand on line 27), then click the Run Button
        //            Keyboard shortcut to run ->  PC: Ctrl+F11 or Mac: Command+fn+F11
        //  Step 2: READ the name of the method that failed
        //  Step 3: FILL IN the blank (___) to make that method pass
        //  Step 4: SAY at least one thing you just learned
        //  Step 5: GO to the next method
        //  IMPORTANT - Do NOT change anything except the blank (___)//
        //

        public void setColorUsingKey()
        {
            var colors = new Dictionary<int, Primitive>();
            colors[10] = Colors.Lime;
            colors[____] = Colors.DarkGreen;
            //Assert.assertEquals(Colors.DarkGreen, colors[20]));
        }
        public void setColorUsingKey2()
        {
            var colors = new Dictionary<int, Primitive> {
                [10] = Colors.Lime,
                [____] = Colors.DarkGreen
            };
            //Assert.assertEquals(Colors.DarkGreen, colors[20]));
        }

        public void findTheGreenKey()
        {
            var colors = new Dictionary<int, Primitive>();
            colors[20] = Colors.DarkGreen;
            colors[30] = Colors.Green;
            //Assert.assertEquals(Colors.Green, colors.get(___));
        }

        public void findTheGreenKey2()
        {
            var colors = new Dictionary<int, Primitive> {
                [20] = Colors.DarkGreen,
                [30] = Colors.Green
            };
            //Assert.assertEquals(Colors.Green, colors.get(___));
        }

        public void findTheColorForTheBananaKey()
        {
            var colors = new Dictionary<String, Primitive>();
            colors["banana"] = Colors.Yellow;
            colors["apple"] = Colors.Red;
            //Assert.assertEquals(_______, colors.get("banana"));
        }

        public void findTheColorForTheBananaKey2()
        {
            var colors = new Dictionary<String, Primitive> {
                ["banana"] = Colors.Yellow,
                ["apple"] = Colors.Red
            };
            //Assert.assertEquals(_______, colors.get("banana"));
        }

        public void findTheNumberPositionOfTheWorld()
        {
            List<String> messages = new List<String>();
            messages.Add("Hello");
            messages.Add("World!");
            messages.Add("How");
            messages.Add("Are");
            messages.Add("You");

            String result = messages[____];
            //Assert.assertEquals("World!", result);
        }

        public void findTheNumberPositionOfTheWorld2()
        {
            var messages = new List<string>();
            messages.Insert(0, "Hello");
            messages.Insert(1, "World!");
            messages.Insert(2, "How");
            messages.Insert(3, "Are");
            messages.Insert(4, "You");

            String result = messages[____];
            //Assert.assertEquals("World!", result);
        }

        public void findTheNumberPositionOfTheWorld3()
        {
            List<String> messages = new List<String>() { "Hello", "World!", "How", "Are", "You" };
            String result = messages[____];
            //Assert.assertEquals("World!", result);
        }

        public void getWhatsLast()
        {
            List<String> messages = new List<String>() { "Hello", "World!", "How", "Are", "You" };
            String result = messages[4];
            //Assert.assertEquals(___, result);
        }

        public void whatIsLastNow()
        {
            List<String> messages = new List<String>() { "Hello", "World!", "How", "Are", "You" };
            messages[4] = ___;
            String result = messages[4];
            //Assert.assertEquals("The rest of them", result);
        }

        public void putAQuarterAtTheEnd()
        {
            int[] coins = new int[4];
            coins[0] = 1;
            coins[1] = 5;
            coins[2] = 10;
            coins[3] = ____;

            //Assert.assertEquals(25, coins[3]);
        }

        public void putAQuarterAtTheEnd2()
        {
            //int[] coins = new int[] { 1, 5, 10, ____ };
            //int[] coins = new [] { 1, 5, 10, ____ };
            int[] coins = { 1, 5, 10, ____ };
            
            //Assert.assertEquals(25, coins[3]);
        }

        public void getThirdCoin()
        {
            int[] coins = { 1, 5, 10, 25 };
            //Assert.assertEquals(10, coins[____]);
        }

        public void whichCoinIsSecond()
        {
            int[] coins = { 1, 5, 10, 25 };
            //Assert.assertEquals(____, coins[1]);
        }

        public void putAFiftyCentPieceFirst()
        {
            int[] coins = { 1, 5, 10, 25 };
            coins[0] = ____;
            //Assert.assertEquals(50, coins[0]);
        }
        /**
         * Ignore the following, It's needed to run the deep dive
         *
         *
         *
         *
         *
         *
         *
         *
         *
         *
         */
        public bool _____ = false;
        public bool ______ = true;
        public String ___ = "You need to fill in the blank ___";
        public int ____ = 0;
        public Primitive _______;
    }
}
