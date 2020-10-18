namespace Lab_2
{
    partial class ChangePass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.new_pass_again = new System.Windows.Forms.TextBox();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.current_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Новый пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Новый пароль (повторить):";
            // 
            // new_pass_again
            // 
            this.new_pass_again.Location = new System.Drawing.Point(281, 121);
            this.new_pass_again.Name = "new_pass_again";
            this.new_pass_again.Size = new System.Drawing.Size(194, 29);
            this.new_pass_again.TabIndex = 1;
            // 
            // new_pass
            // 
            this.new_pass.Location = new System.Drawing.Point(281, 86);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(194, 29);
            this.new_pass.TabIndex = 1;
            // 
            // current_pass
            // 
            this.current_pass.Location = new System.Drawing.Point(281, 51);
            this.current_pass.Name = "current_pass";
            this.current_pass.Size = new System.Drawing.Size(194, 29);
            this.current_pass.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "<<";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.Location = new System.Drawing.Point(455, 9);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(30, 29);
            this.close_btn.TabIndex = 7;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 250);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.current_pass);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.new_pass_again);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ChangePass";
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox new_pass_again;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.TextBox current_pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label close_btn;
    }
}