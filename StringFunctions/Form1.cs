using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mennyi 'a' betű van
            var aBetuk = ABetuszam();
            var szokoz = Szokozszam(richTextBox1.Text);
            var sor = SorokSzama(richTextBox1.Text); 

            //írja ki
            label1.Text = "Az 'a' betűk száma: " + aBetuk;

            szokozokSzama.Text = "Szóközök száma: " + szokoz;

            sorokSzama.Text = "Sorok száma: " + sor;

            Szoszam.Text = "Szavak száma: " + CalcSzoszam();

        }

        private int ABetuszam()
        {
            // "askldnaksdjbasd"
            //  100000100000100
            var szamlalo = 0;

            foreach (var karakter in richTextBox1.Text)
            {
                if (karakter =='a' || karakter == 'A')
                {
                    szamlalo += 1;
                }
            }
            
            return szamlalo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private static int Szokozszam(string text)
        {
            var szamlalo = 0;

            foreach (var karakter in text)
            {
                if (karakter == ' ')
                {
                    szamlalo += 1;
                }
            }

            return szamlalo;
        }

        private int SorokSzama(string text)
        {
            var sorSzamlalo = 1;

            foreach (var karakter in text)
            {
                if (karakter == '\n')
                {
                    sorSzamlalo += 1;
                }
            }

            return sorSzamlalo;
        }

        private int CalcSzoszam()
        {
            var strings = Regex.Matches(richTextBox1.Text, "[^ \\n\\t,;.]+");
            return strings.Count;
        }

        private int CalcSzoszam_Old()
        {
            var joSzokoz = Regex.Replace(richTextBox1.Text, " +", " ");
            int szokozSzam = Szokozszam(joSzokoz);

            var joEnter = Regex.Replace(richTextBox1.Text, "\n+", "\n");
            var sorokSzama = SorokSzama(joEnter) -1;

            var szo = szokozSzam + sorokSzama;
            return szo;
        }
    }
}
