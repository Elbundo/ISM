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
    public partial class info_page : Form
    {
        public info_page()
        {
            InitializeComponent();
        }

        private void Info_page_Load(object sender, EventArgs e)
        {
            login_lb.Text = Person.login;
            surname_lb.Text = Person.surname;
            name_lb.Text = Person.name;
            secondname_lb.Text = Person.secondname;
            dob_lb.Text = Person.dateofbirth;
            bpl_lb.Text = Person.placeofbirth;
            phN_lb.Text = Person.phonenumber;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            main_page MP = new main_page();
            MP.Show();
            this.Close();
        }
    }
}
