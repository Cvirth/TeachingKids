﻿using System;
using Microsoft.SmallBasic.Library;
using SmallBasicFun;

namespace Houses
{
	public class HousesHomework
	{
		// How to do homework:
		// Step 1: Press the Run Button (Ctrl+F5)
		// Step 2: Read the name of the Method that Failed
		// Step 3: Fill in the blank (___) to make it pass
		// Step 4: Repeat Until Enlightment
		// Do not change anything except the blank (___)
		private static void youcanreadvariables()
		{
			var numberOfDesserts = 5;
			Homework.CheckAnswer(5, equals, numberOfDesserts);
		}

		private static void youcansavevariables()
		{
			var ickynessOfBrothers = 10;
			Homework.CheckAnswer(10, equals, ickynessOfBrothers);
		}

		private static void youcandomathwithvariables()
		{
			var numberOfHarryPotterBooks = 3 + 4;
			Homework.CheckAnswer(7, equals, numberOfHarryPotterBooks);
		}

		private static void youcanchangevariables()
		{
			var milkTastiness = 6;
			addChocolate();
			milkTastiness = 10;
			Homework.CheckAnswer(10, equals, milkTastiness);
		}

		private static void addChocolate()
		{
		}


		private static void variablesaresnotstuck()
		{
			var boogers = 4;
			blowNose();
			boogers = 0;
			Homework.CheckAnswer(0, equals, boogers);
		}

		private static void blowNose()
		{
		}

		private static void youcanaddtoavariable()
		{
			var age = 11;
			celebrateBirthday();
			age = age + 1;
			Homework.CheckAnswer(12, equals, age);
		}

		private static void celebrateBirthday()
		{
		}

		private static void youcansubtractfromavariable()
		{
			var amountOfHomework = 3;
			amountOfHomework = amountOfHomework - 3;
			Homework.CheckAnswer(0, equals, amountOfHomework);
		}

		private static void youcanmultiplyvariables()
		{
			var volumeOfMyVoice = 2;
			var volumeMyMomHears = volumeOfMyVoice*5;
			Homework.CheckAnswer(10, equals, volumeMyMomHears);
		}

		private static void youcandividevariables()
		{
			var inches = 36;
			var feet = inches/12;
			Homework.CheckAnswer(3, equals, feet);
		}

		private static void youcansetvariablesinothermethods()
		{
			CreateXmasList();
			Homework.CheckAnswer("hippopotamus", equals, xmasList);
		}

		private static void CreateXmasList()
		{
			xmasList = "hippopotamus";
		}

		private static void youcancallmethodsbyname()
		{
			PrepareForBed();
			Homework.CheckAnswer("gum", equals, bedPost);
		}

		private static void PrepareForBed()
		{
			bedPost = "gum";
		}

		private static void youcanchoosethemethodnames()
		{
            SetThingsThatSmellFunny();
			Homework.CheckAnswer("feet", equals, thingsThatSmellFunny);
			// You need to change two blanks for this problem
		}


		private static void SetThingsThatSmellFunny()
		{
			thingsThatSmellFunny = "feet";
		}

		private static void changingvariableinothermethods()
		{
			height = 4;
			Grow();
			Homework.CheckAnswer(5, equals, height);
		}

		private static void Grow()
		{
			height = height + 1;
		}

		#region Ignore

		public static void Main2()
		{
			Homework.StartHousesHomeworkAt += youcanreadvariables;
		}


		private static readonly Primitive ___ = "Fill in the blank ___";
		private static readonly Primitive ____ = 1;

		private static readonly Primitive equals = "=";
		private static int height;
		private static Primitive thingsThatSmellFunny;
		private static Primitive bedPost;
		private static Primitive xmasList;
		private static Primitive numberOfHarryPotterBooks = ___;

		private static void ______()
		{
			throw new Exception("Fill in the blank ___");
		}

		#endregion
	}
}