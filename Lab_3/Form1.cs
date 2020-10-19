using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double P, V, T;
            try
            {
                P = Convert.ToDouble(P_tb.Text);
                V = Convert.ToDouble(V_tb.Text);
                T = Convert.ToDouble(T_tb.Text);
            }
            catch (Exception e1) {
                MessageBox.Show("Введены некоректные данные!");
                return;
            }
            string engUP = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string englow = engUP.ToLower();
            string rusUP = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string ruslow = rusUP.ToLower();
            string chars= "!\"#$%&\'()*";
            string numbers= "0123456789";
            string alphabet = "";
            int S = (int)Math.Ceiling(V * T / P);
            double A = 0, L = 0;
            if (checkBox1.Checked) alphabet += engUP;
            if (checkBox2.Checked) alphabet += englow;
            if (checkBox3.Checked) alphabet += rusUP;
            if (checkBox4.Checked) alphabet += ruslow;
            if (checkBox5.Checked) alphabet += chars;
            if (checkBox6.Checked) alphabet += numbers;
            A = alphabet.Length;
            if (A == 0) {
                MessageBox.Show("Выбирете символы из которых должен состоять пароль!");
                return;
            }
            while (S > Math.Pow(A, L)) {
                L++;
            }
            S_tb.Text = Convert.ToString(S);
            A_tb.Text = Convert.ToString(A);
            L_tb.Text = Convert.ToString(L);
            string password = "";
            Random rnd = new Random();
            for (int i = 0; i < L; i++) {
                password += alphabet[rnd.Next(alphabet.Length)];
            }
            password_lb.Text = password;
        }
    }
}
