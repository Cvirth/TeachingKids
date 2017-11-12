using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingKids._03.HiLow
{
    public class DeepDive03Ifs
    {
        //  Step 1: SELECT the method name (doesABear on line 19), then click the Run Button
        //            Keyboard shortcut to run ->  PC: Ctrl+F11 or Mac: Command+fn+F11
        //  Step 2: READ the name of the method that failed
        //  Step 3: FILL IN the blank (___) to make that method pass
        //  Step 4: SAY at least one thing you just learned
        //  Step 5: GO to the next method
        //  IMPORTANT - Do NOT change anything except the blank (___)//  
        //  

        public void doesABear()
        {
            String bearPoopPlace = "";

            bool b = true; //false

            // true false
            // not true -> false
            // ! true -> false


            var feltetel = 1 > 3;
            if (feltetel)
            {
                //...
            }

            if (true)
            {
                bearPoopPlace = "woods";
            }
            //Assert.assertEquals("woods", bearPoopPlace);
        }

        public void neverEverEver()
        {
            String dessert = "chocolate";
            if (false)
            {
                dessert = "ketchup";
            }
            //Assert.assertEquals("chocolate", dessert);
        }

        public void notEverEverEver()
        {
            String dessert = "chocolate";
            if (!true)
            {
                dessert = "ketchup";
            }
            //Assert.assertEquals("chocolate", dessert);
        }

        public void isThePopeCatholic()
        {
            String pope = "";
            if (true)
            {
                pope = "Catholic";
            }
            //Assert.assertEquals("Catholic", pope);
        }

        public void trueOrFalse()
        {
            String animal = "cat";
            bool elephant = true;
            if (elephant)
            {
                animal = "flat " + animal;
            }
            //Assert.assertEquals("flat cat", animal);
        }

        public void letSleepingBabiesLie()
        {
            String babySounds = "";
            bool sleeping = false;
            if (sleeping)
            {
                babySounds = "zzzzzzzzzzzz";
            }
            else
            {
                babySounds = "waaaaaahhh!";
            }
            //Assert.assertEquals("waaaaaahhh!", babySounds);
        }

        public void howCoachThinks()
        {
            String coachSays = "try harder";
            int percentEffort = 110;
            if (percentEffort == 110)
            {
                coachSays = "good job";
            }
            //Assert.assertEquals("good job", coachSays);
        }

        public void lessThan()
        {
            String modeOfTransportation = "";
            int age = 15;
            if (age < 16)
            {
                modeOfTransportation = "keep walking";
            }
            else
            {
                modeOfTransportation = "drive away";
            }
            //Assert.assertEquals("keep walking", modeOfTransportation);
        }

        public void greaterThan()
        {
            String kidSays = "";
            int numberOfIceCreams = 5;
            if (numberOfIceCreams > 4)
            {
                kidSays = "I think I'm gonna barf";
            }
            else
            {
                kidSays = "More ice cream!";
            }
            //Assert.assertEquals("I think I'm gonna barf", kidSays);
        }

        public void notEqual()
        {
            String playerSays = "";
            int cards = 52;
            if (cards != 52) // == != >= <=   ---  rossz: =< =>
            {
                playerSays = "Not playing with a full deck!";
            }
            else
            {
                playerSays = "Game on!";
            }
            //Assert.assertEquals("Game on!", playerSays);
        }

        public void equalsForStrings()
        {
            String knockKnock = "";
            String whosThere = "bananas";
            if (whosThere == "bananas")                           //if (whosThere.Equals("bananas"))
            {
                knockKnock = "Who's there?";
            }
            else if (whosThere == "orange")                      //else if (whosThere.Equals("orange"))
            {
                knockKnock = "Orange you glad I didn't say bananas?";
            }
            //Assert.assertEquals("Who's there?", knockKnock);
        }

        public void thisAndThat()
        {
            String time = "";
            int score = 4;
            int years = 7;
            if (score == 4 && years == 7)
            {
                time = "Presidential";
            }
            //Assert.assertEquals("Presidential", time);
        }

        public void theBeginningOrEnd()
        {
            String shoppingList = "";
            int age = 1;
            if (age <= 2 || 90 <= age)
            //if (age <= 2 ^ 90 <= age)
            {
                shoppingList = "diapers";
            }
            //Assert.assertEquals("diapers", shoppingList);
        }

        public void ifInHighSchool()
        {
            String status = "";
            int age = 18;
            if (age <= 15)
            {
                status = "smarty";
            }
            else if (age > 19)
            {
                status = "dummy";
            }
            else
            {
                status = "normal";
            }
            //Assert.assertEquals("normal", status);
        }

        public void nestedIfOrPigsInABlanket()
        {
            String status = "";
            String animal = "PIG";
            bool isWinningKarate = false;
            if (animal.Equals("pig", StringComparison.InvariantCultureIgnoreCase))
            {
                if (isWinningKarate)
                {
                    status = "pork chop";
                }
                else
                {
                    status = "hambulance";
                }
            }
            //Assert.assertEquals("hambulance", status);
        }

        public void semicolonsMessUpIfStatements()
        {
            String dessert = "chocolate";
            if (false)
                ;
            {
                dessert = "ketchup";
            }
            //Assert.assertEquals("ketchup", dessert);
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
        public int ____ = -99999;
        public String ________()
        {
            return ___;
        }
    }
}
