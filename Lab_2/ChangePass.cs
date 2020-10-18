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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            main_page MP = new main_page();
            MP.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (current_pass.Text == "" || new_pass.Text == "" || new_pass_again.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else {
                if (current_pass.Text != Person.password)
                {
                    MessageBox.Show("Текущий пароль введен неверно!");
                }
                else {
                    if (new_pass.Text != new_pass_again.Text)
                    {
                        MessageBox.Show("Пароли не совпадают!");
                    }
                    else
                    {
                        if (new_pass.Text.Length != 6)
                        {
                            MessageBox.Show("Длина пароля должна быть равна 6!");
                        }
                        else
                        {
                            string alphabet = "abcdefghijklmnopqrstuvwxyz";
                            bool a = true;
                            for (int i = 0; i < new_pass.Text.Length; i++)
                            {
                                if (alphabet.IndexOf(new_pass.Text[i]) == -1)
                                {
                                    a = false;
                                    break;
                                }
                            }
                            if (!a)
                            {
                                MessageBox.Show("Пароль должен состоять только из строчных латинских букв!");
                            }
                            else {
                                Person.password = new_pass.Text;
                                string[] readText = System.IO.File.ReadAllLines("TestFile.txt");
                                using (System.IO.StreamWriter file = new System.IO.StreamWriter("TestFile.txt", false))
                                {
                                    int b = 0;
                                    for (int i = 0; i < readText.Length; i++)
                                    {
                                        if (readText[i] == "Имя пользователя:")
                                        {
                                            if (readText[i + 1] == Person.login)
                                            {
                                                b = i + 3;
                                                break;
                                            }
                                        }
                                    }
                                    for (int i = 0; i < readText.Length; i++)
                                    {
                                        if (i == b)
                                            file.WriteLine(Person.password);
                                        else
                                            file.WriteLine(readText[i]);
                                    }
                                }
                                MessageBox.Show("Пароль успешно изменен!");
                                main_page MP = new main_page();
                                MP.Show();
                                this.Close();
                            }
                        }
                    }
                }
            }
        }
    }
}
