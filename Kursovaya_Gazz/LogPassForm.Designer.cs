﻿
namespace Kursovaya_Gazz
{
    partial class LogPassForm
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(147, 146);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(246, 28);
            this.tbPassword.TabIndex = 0;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(147, 67);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(246, 28);
            this.tbLogin.TabIndex = 1;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(178, 197);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(197, 44);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // LogPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(575, 254);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbPassword);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LogPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogPassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}