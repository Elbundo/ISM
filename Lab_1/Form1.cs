using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string alphabet = "!\"#$%&\'()*";
            result_pass.Text = "" + ((char)rnd.Next('\u0041', '\u005A')) + ((char)rnd.Next('\u0041', '\u005A')) + Convert.ToString((id_tb.Text.Length* id_tb.Text.Length) % 10) + Convert.ToString(rnd.Next(10)) + alphabet[rnd.Next(alphabet.Length)] + (char)rnd.Next('\u0061', '\u007A');
        }
    }
}
