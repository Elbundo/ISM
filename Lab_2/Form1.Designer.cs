namespace Lab_2
{
    partial class auth_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.logIn_btn = new System.Windows.Forms.Button();
            this.sing = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пароль";
            // 
            // login_tb
            // 
            this.login_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_tb.Location = new System.Drawing.Point(36, 47);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(192, 29);
            this.login_tb.TabIndex = 1;
            // 
            // pass_tb
            // 
            this.pass_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_tb.Location = new System.Drawing.Point(36, 118);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(192, 29);
            this.pass_tb.TabIndex = 1;
            // 
            // logIn_btn
            // 
            this.logIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logIn_btn.Location = new System.Drawing.Point(12, 166);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(237, 34);
            this.logIn_btn.TabIndex = 2;
            this.logIn_btn.Text = "Войти";
            this.logIn_btn.UseVisualStyleBackColor = true;
            this.logIn_btn.Click += new System.EventHandler(this.LogIn_btn_Click);
            // 
            // sing
            // 
            this.sing.AutoSize = true;
            this.sing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sing.Location = new System.Drawing.Point(76, 214);
            this.sing.Name = "sing";
            this.sing.Size = new System.Drawing.Size(106, 20);
            this.sing.TabIndex = 3;
            this.sing.Text = "Регистрация";
            this.sing.Click += new System.EventHandler(this.Sing_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(225, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // auth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 253);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sing);
            this.Controls.Add(this.logIn_btn);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.login_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "auth_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Auth_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Button logIn_btn;
        private System.Windows.Forms.Label sing;
        private System.Windows.Forms.Label label9;
    }
}

