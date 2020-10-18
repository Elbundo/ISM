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
    public partial class singup_form : Form
    {
        public singup_form()
        {
            InitializeComponent();
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            auth_form AF = new auth_form();
            this.Close();
            AF.Show();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SingUP_btn_Click(object sender, EventArgs e)
        {
            if (login_tb.Text == "" || pass_tb.Text == "" || SurName_tb.Text == "" || Name_tb.Text == "" || dob_tb.Text == "" || bpl_tb.Text == "" || phoneNumber_tb.Text == "") {
                MessageBox.Show("Заполните все поля");
            }
            else {
                if (pass_tb.Text.Length != 6)
                {
                    MessageBox.Show("Длина пароля должна быть равна 6!");
                }
                else {
                    string alphabet = "abcdefghijklmnopqrstuvwxyz";
                    bool a = true;
                    for (int i = 0; i < pass_tb.Text.Length; i++) {
                        if (alphabet.IndexOf(pass_tb.Text[i]) == -1) {
                            a = false;
                            break;
                        }
                    }
                    if (!a)
                    {
                        MessageBox.Show("Пароль должен состоять только из строчных латинских букв!");
                    }
                    else {
                        try
                        {
                            using (StreamReader sr = new StreamReader("TestFile.txt"))
                            {
                                string line, login;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    if (line == "Имя пользователя:")
                                    {
                                        login = sr.ReadLine();
                                        if (login == login_tb.Text)
                                        {
                                            MessageBox.Show("Пользователь с таким именем пользователя уже существует!");
                                            return;
                                        }
                                    }
                                }
                            }
                            using (StreamWriter sw = new StreamWriter("TestFile.txt", true))
                            {
                                sw.WriteLine("Имя пользователя:");
                                sw.WriteLine(login_tb.Text);
                                sw.WriteLine("Пароль:");
                                sw.WriteLine(pass_tb.Text);
                                sw.WriteLine("Фамилия:");
                                sw.WriteLine(SurName_tb.Text);
                                sw.WriteLine("Имя:");
                                sw.WriteLine(Name_tb.Text);
                                sw.WriteLine("Отчество:");
                                sw.WriteLine(patronymic_tb.Text);
                                sw.WriteLine("Дата рождения:");
                                sw.WriteLine(dob_tb.Text);
                                sw.WriteLine("Место рождения:");
                                sw.WriteLine(bpl_tb.Text);
                                sw.WriteLine("Номер телефона:");
                                sw.WriteLine(phoneNumber_tb.Text);
                                sw.WriteLine();
                                MessageBox.Show("Регистрация прошла успешно!");
                                sw.Close();
                                auth_form AF = new auth_form();
                                AF.Show();
                                this.Close();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("Упс, что-то пошло не так!\n" + e1.Message);
                        }
                    }
                }
            }
        }
    }
}
