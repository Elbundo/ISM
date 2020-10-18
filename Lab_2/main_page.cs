using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void Main_page_Load(object sender, EventArgs e)
        {
            this.Text = Person.surname + " " + Person.name;
            header_tb.Text = Person.surname + " " + Person.name;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            auth_form AF = new auth_form();
            AF.Show();
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            ChangePass CP = new ChangePass();
            CP.Show();
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            info_page IP = new info_page();
            IP.Show();
            this.Close();
        }
    }
}
