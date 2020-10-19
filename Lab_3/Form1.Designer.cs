namespace Lab_3
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.T_tb = new System.Windows.Forms.TextBox();
            this.V_tb = new System.Windows.Forms.TextBox();
            this.P_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.S_tb = new System.Windows.Forms.Label();
            this.A_tb = new System.Windows.Forms.Label();
            this.L_tb = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.password_lb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "P (вероятность)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "V (скорость перебора)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "T (срок действия пароля)";
            // 
            // T_tb
            // 
            this.T_tb.Location = new System.Drawing.Point(257, 128);
            this.T_tb.Name = "T_tb";
            this.T_tb.Size = new System.Drawing.Size(204, 29);
            this.T_tb.TabIndex = 1;
            // 
            // V_tb
            // 
            this.V_tb.Location = new System.Drawing.Point(257, 93);
            this.V_tb.Name = "V_tb";
            this.V_tb.Size = new System.Drawing.Size(204, 29);
            this.V_tb.TabIndex = 1;
            // 
            // P_tb
            // 
            this.P_tb.Location = new System.Drawing.Point(257, 58);
            this.P_tb.Name = "P_tb";
            this.P_tb.Size = new System.Drawing.Size(204, 29);
            this.P_tb.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "S* (нижняя граница паролей)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "A (мощность алфавита)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "L (длина пароля)";
            // 
            // S_tb
            // 
            this.S_tb.AutoSize = true;
            this.S_tb.Location = new System.Drawing.Point(289, 194);
            this.S_tb.Name = "S_tb";
            this.S_tb.Size = new System.Drawing.Size(0, 24);
            this.S_tb.TabIndex = 0;
            // 
            // A_tb
            // 
            this.A_tb.AutoSize = true;
            this.A_tb.Location = new System.Drawing.Point(289, 229);
            this.A_tb.Name = "A_tb";
            this.A_tb.Size = new System.Drawing.Size(0, 24);
            this.A_tb.TabIndex = 0;
            // 
            // L_tb
            // 
            this.L_tb.AutoSize = true;
            this.L_tb.Location = new System.Drawing.Point(289, 264);
            this.L_tb.Name = "L_tb";
            this.L_tb.Size = new System.Drawing.Size(0, 24);
            this.L_tb.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(620, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(208, 28);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Латинские большие";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(620, 91);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(226, 28);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Латинские маленькие";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(620, 125);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(185, 28);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Русские большие";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(620, 159);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(203, 28);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Русские маленькие";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(620, 190);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(111, 28);
            this.checkBox5.TabIndex = 2;
            this.checkBox5.Text = "Символы";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(620, 224);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(90, 28);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Text = "Цифры";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Пароль:";
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Location = new System.Drawing.Point(99, 330);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(0, 24);
            this.password_lb.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сформировать пароль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.P_tb);
            this.Controls.Add(this.V_tb);
            this.Controls.Add(this.T_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_tb);
            this.Controls.Add(this.A_tb);
            this.Controls.Add(this.S_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Lab3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T_tb;
        private System.Windows.Forms.TextBox V_tb;
        private System.Windows.Forms.TextBox P_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label S_tb;
        private System.Windows.Forms.Label A_tb;
        private System.Windows.Forms.Label L_tb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Button button1;
    }
}

