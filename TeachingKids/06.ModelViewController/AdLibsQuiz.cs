using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingKids._06.ModelViewController
{
    class AdLibsQuiz
    {
        public void Question1(String letter1, String letter3)
        {
            //  Set current value of word1 to be letter1 + 'o' + letter3
            var word1 = letter1 + 'o' + letter3;
        }
        public void Question2(String letter1)
        {
            //  Add the letter1 to the end of word2 
            var word2 = "";
            word2 += letter1;
        }
        public void Question3(String templateText, Object model)
        {
            //  Use the parser to combine the template and the model as word3
            var word3 = "";
            word3 += templateText + model;
        }
    }
}
