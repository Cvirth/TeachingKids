using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;
using SmallBasicFun;

namespace TeachingKids._04.Mastery
{
	class PentagonCrazyHomework
	{
		//  Step 1: SELECT the method name (theseNumbersCount on line 21), then click the Run Button
		//            Keyboard shortcut to run ->  PC: Ctrl+F11 or Mac: Command+fn+F11
		//  Step 2: READ the name of the method that failed
		//  Step 3: FILL IN the blank (___) to make that method pass
		//  Step 4: SAY at least one thing you just learned
		//  Step 5: GO to the next method
		//  IMPORTANT - Do NOT change anything except the blank (___)//  
		//  

		public void theseNumbersCount()
		{
			int number = 2;
			//var thisIsTrue = number is _______;
		}

		public void textTypes()
		{
			String text = "Beans";
			//var thisIsTrue = text is _______;
		}

		public void theNumbersAfterTheDot()
		{
			Double number = 2.3;
			//var thisIsTrue = number is _______;
		}

		public void everythingIsAnObject()
		{
			Object number = 2.3;
			//var thisIsTrue = number is _______;
		}

		public void iMeanEverythingIsAnObject()
		{
			Object number = 2;
			//var thisIsTrue = number is _______;
		}

		public void iMeanEverySinglethingIsAnObject()
		{
			Object number = "Everything";
			//var thisIsTrue = number is _______;
		}

		public void integersAreATypeOfNumber()
		{
			var number = 2;
			//var thisIsTrue = number is _______;
		}

		public void doublesAreATypeOfNumber()
		{
			var number = 2.0;
			//var thisIsTrue = number is _______;
		}

		public void addingIntegers()
		{
			var number = 2 + 3;
			//var thisIsTrue = number is _______;
		}

		public void addingDoubles()
		{
			var number = 2.1 + 3.2;
			//var thisIsTrue = number is _______;
		}

		public void addingMixedTypes()
		{
			var number = 2 + 0.1;
			//var thisIsTrue = number is _______;
			//Assert.assertEquals(number, ____);
		}

		public void addingMixingMoreTypes()
		{
			Object number = "19 fought 20, " + 21;
			//var thisIsTrue = number is _______;
			//Assert.assertEquals(number, ____);
		}

		public void convertingToText()
		{
			int number = 21;
			String text = number.ToString();
			//var thisIsTrue = text is _______;
			//Assert.assertEquals(text, ____);
		}

		public void convertingToText2()
		{
			int number = 21;
			String text = "" + number;
			//var thisIsTrue = text is _______;
			//Assert.assertEquals(text, ____);
		}

		public void dividing()
		{
			var number = 1.0 / 5;
			//var thisIsTrue = number is _______;
			//Assert.assertEquals(number, ___);
		}

		public void dividingIntegers()
		{
			var number = 11 / 5;
			//var thisIsTrue = number is _______;
			//Assert.assertEquals(number, ____);
		}

		public void understandingNumbers()
		{
			String text = "42";
			var theAnswer = int.Parse(text);
			//var thisIsTrue = theAnswer is _______;
			//Assert.assertEquals(theAnswer, ____);
		}

		public void understandingDoubleNumbers()
		{
			String text = "42";
			var theAnswer = Double.Parse(text);
			//var thisIsTrue = theAnswer is _______;
			//Assert.assertEquals(theAnswer, ____);
		}
	}
}
