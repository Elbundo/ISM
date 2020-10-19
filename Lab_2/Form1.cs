using System;
using System.IO;
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
    public partial class auth_form : Form
    {
        public auth_form()
        {
            InitializeComponent();
        }

        private void Sing_Click(object sender, EventArgs e)
        {
            singup_form SF = new singup_form();
            this.Hide();
            SF.Show();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            if (login_tb.Text == "" || pass_tb.Text == "")
            {
                MessageBox.Show("Введите логин или пароль!");
            }
            else
            {
                bool is_auth = false;
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    string line, login, pass;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == "Имя пользователя:")
                        {
                            login = sr.ReadLine();
                            if (login == login_tb.Text)
                            {
                                pass = sr.ReadLine();
                                pass = sr.ReadLine();
                                if (pass == pass_tb.Text)
                                {
                                    Person.login = login;
                                    Person.password = pass;

                                    Person.surname = sr.ReadLine();
                                    Person.surname = sr.ReadLine();

                                    Person.name = sr.ReadLine();
                                    Person.name = sr.ReadLine();

                                    Person.secondname = sr.ReadLine();
                                    Person.secondname = sr.ReadLine();

                                    Person.dateofbirth = sr.ReadLine();
                                    Person.dateofbirth = sr.ReadLine();

                                    Person.placeofbirth = sr.ReadLine();
                                    Person.placeofbirth = sr.ReadLine();

                                    Person.phonenumber = sr.ReadLine();
                                    Person.phonenumber = sr.ReadLine();
                                    main_page MP = new main_page();
                                    is_auth = true;
                                    MP.Show();
                                    this.Hide();
                                }
                                else {
                                    MessageBox.Show("Неверные логин или пароль!");
                                    return;
                                }
                            }
                        }
                    }

                }
                if (!is_auth) {
                    MessageBox.Show("Неверные логин или пароль!");
                }
            }
        }

        private void Auth_form_Load(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("TestFile.txt", true);
            sw.Close();
        }
    }
}
