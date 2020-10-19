using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = 17, b = 11, c = 256, t0 = 172;
            char[] str = str_tb.Text.ToCharArray();
            int summ = 0;
            int summk = 0;
            char[] t = new char[str.Length];
            for (int i = 0; i < str.Length; i++) {
                summ += str[i];
                summk += str[i] ^ (t0 = (a * t0 + b) % c);
            }
            KSumm_lb.Text = Convert.ToString(summ % c);
            SummKod_lb.Text = Convert.ToString(summk % c);
        }
    }
}
