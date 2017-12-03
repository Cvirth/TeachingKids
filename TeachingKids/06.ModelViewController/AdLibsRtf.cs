using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBasicFun;

namespace TeachingKids._06.ModelViewController
{
    public class Kutya
    {
        public int meret;
        public string fajta;
        public string nev;

        public static bool tudUgatni;
    }

    public class Words
    {
        public string currentAdverb;
        public string currentEdVerb;
        public string currentBodyPart;

        public void osszefuzve()
        {
            MessageBox.ShowMessage(currentAdverb + currentBodyPart + currentEdVerb);
        }

    }

    class AdLibsRtf
    {
        public static void Start()
        {
            int bbb = 2;
            int aaa = 1;
            string bb1 = aaa + "1";                  // "11"
            string bb3 = (aaa + 1).ToString();       // "2"
            string bb2 = bbb.ToString() + aaa + 1;
            MessageBox.ShowMessage(bb2);
        }

        private static void Feladat1()
        {
            var word = new Words();
            word.currentAdverb = MessageBox.AskForInput("Enter an adverb.");
            word.currentEdVerb = MessageBox.AskForInput("Enter a verb ending in '-ed'! ");
            word.currentBodyPart = MessageBox.AskForInput("Enter a body part! ");
            word.osszefuzve();
            //MessageBox.ShowMessage(word.currentAdverb + word.currentBodyPart + word.currentEdVerb);
            var currentStory = "...";

            var words2 = new Words();
            words2.osszefuzve();
        }

        /*
            Kutya.tudUgatni = true;

            var lili = new Kutya();
            lili.fajta = "uszkár";
            lili.meret = 1;
            lili.nev = "Lili";

            var odin = new Kutya();
            odin.fajta = "uszkár";
            odin.meret = 2;
            odin.nev = "Odin";




            var words = new Words();
            words.Adverb = "aaaa";
            words.Verb = "bbbb";
         */
    }
}
