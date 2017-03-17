using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Japanese
{
    public partial class Form1 : Form
    {


        SpeechSynthesizer synthesizer;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;

            synthesizer = new SpeechSynthesizer();
        }

        private string japaneseChar( char ch)
        {
            if (ch == 'A')
                return "KA";
            else if (ch == 'B')
                return "TU";
            else if (ch == 'C')
                return "MI";
            else if (ch == 'D')
                return "TE";
            else if (ch == 'E')
                return "KU";
            else if (ch == 'F')
                return "LU";
            else if (ch == 'G')
                return "JI";
            else if (ch == 'H')
                return "RI";
            else if (ch == 'I')
                return "KI";
            else if (ch == 'J')
                return "ZU";
            else if (ch == 'K')
                return "ME";
            else if (ch == 'L')
                return "TA";
            else if (ch == 'M')
                return "RIN";
            else if (ch == 'N')
                return "TO";
            else if (ch == 'O')
                return "MO";
            else if (ch == 'P')
                return "NO";
            else if (ch == 'Q')
                return "KE";
            else if (ch == 'R')
                return "SHI";
            else if (ch == 'S')
                return "ARI";
            else if (ch == 'T')
                return "CHI";
            else if (ch == 'U')
                return "DO";
            else if (ch == 'V')
                return "RU";
            else if (ch == 'W')
                return "MEI";
            else if (ch == 'X')
                return "NA";
            else if (ch == 'Y')
                return "FU";
            else if (ch == 'Z')
                return "ZI";

            return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Name correctly!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string name = textBox1.Text.ToUpper();
            string temp = "";

            for (int i = 0; i < name.Length; i++)
            {
                temp += japaneseChar(name[i]);
                
            }

            label2.Text = temp;
            label3.Visible = true;

            synthesizer.SpeakAsync(temp);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
