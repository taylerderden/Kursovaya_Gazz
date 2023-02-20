﻿
namespace Kursovaya_Gazz
{
    partial class RegistrationForm
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
            this.tbSchet = new System.Windows.Forms.TextBox();
            this.labelSchet = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.labelSq = new System.Windows.Forms.Label();
            this.tbSquare = new System.Windows.Forms.TextBox();
            this.labelPeople = new System.Windows.Forms.Label();
            this.tbPeople = new System.Windows.Forms.TextBox();
            this.btnCreateAbonent = new System.Windows.Forms.Button();
            this.cbTarif = new System.Windows.Forms.ComboBox();
            this.cbLgota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSchet
            // 
            this.tbSchet.Location = new System.Drawing.Point(12, 32);
            this.tbSchet.MaxLength = 12;
            this.tbSchet.Name = "tbSchet";
            this.tbSchet.Size = new System.Drawing.Size(206, 25);
            this.tbSchet.TabIndex = 0;
            // 
            // labelSchet
            // 
            this.labelSchet.AutoSize = true;
            this.labelSchet.Location = new System.Drawing.Point(8, 10);
            this.labelSchet.Name = "labelSchet";
            this.labelSchet.Size = new System.Drawing.Size(156, 19);
            this.labelSchet.TabIndex = 1;
            this.labelSchet.Text = "Номер лицевого счета";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(8, 60);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(105, 19);
            this.labelFIO.TabIndex = 3;
            this.labelFIO.Text = "Фамилия И.О.";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(12, 87);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(206, 25);
            this.tbFIO.TabIndex = 2;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(8, 115);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(48, 19);
            this.labelAdress.TabIndex = 5;
            this.labelAdress.Text = "Адрес";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(12, 137);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(206, 25);
            this.tbAdress.TabIndex = 4;
            // 
            // labelSq
            // 
            this.labelSq.AutoSize = true;
            this.labelSq.Location = new System.Drawing.Point(8, 171);
            this.labelSq.Name = "labelSq";
            this.labelSq.Size = new System.Drawing.Size(210, 19);
            this.labelSq.TabIndex = 7;
            this.labelSq.Text = "Отапливаемая площадь (кв.м)";
            // 
            // tbSquare
            // 
            this.tbSquare.Location = new System.Drawing.Point(12, 193);
            this.tbSquare.Name = "tbSquare";
            this.tbSquare.Size = new System.Drawing.Size(206, 25);
            this.tbSquare.TabIndex = 6;
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Location = new System.Drawing.Point(8, 221);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(190, 19);
            this.labelPeople.TabIndex = 9;
            this.labelPeople.Text = "Количество проживающих";
            // 
            // tbPeople
            // 
            this.tbPeople.Location = new System.Drawing.Point(12, 248);
            this.tbPeople.MaxLength = 2;
            this.tbPeople.Name = "tbPeople";
            this.tbPeople.Size = new System.Drawing.Size(206, 25);
            this.tbPeople.TabIndex = 8;
            // 
            // btnCreateAbonent
            // 
            this.btnCreateAbonent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.btnCreateAbonent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAbonent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCreateAbonent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCreateAbonent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAbonent.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateAbonent.ForeColor = System.Drawing.Color.White;
            this.btnCreateAbonent.Location = new System.Drawing.Point(144, 301);
            this.btnCreateAbonent.Name = "btnCreateAbonent";
            this.btnCreateAbonent.Size = new System.Drawing.Size(206, 38);
            this.btnCreateAbonent.TabIndex = 10;
            this.btnCreateAbonent.Text = "Создать аккаунт";
            this.btnCreateAbonent.UseVisualStyleBackColor = false;
            this.btnCreateAbonent.Click += new System.EventHandler(this.btnCreateAbonent_Click);
            // 
            // cbTarif
            // 
            this.cbTarif.FormattingEnabled = true;
            this.cbTarif.Items.AddRange(new object[] {
            "Экономичный",
            "Стандартный",
            "Неограниченный"});
            this.cbTarif.Location = new System.Drawing.Point(286, 32);
            this.cbTarif.Name = "cbTarif";
            this.cbTarif.Size = new System.Drawing.Size(206, 26);
            this.cbTarif.TabIndex = 11;
            // 
            // cbLgota
            // 
            this.cbLgota.FormattingEnabled = true;
            this.cbLgota.Items.AddRange(new object[] {
            "Ветераны войны",
            "Беженцы",
            "Пенсионеры",
            "Безработные",
            "Без льгот"});
            this.cbLgota.Location = new System.Drawing.Point(286, 136);
            this.cbLgota.Name = "cbLgota";
            this.cbLgota.Size = new System.Drawing.Size(206, 26);
            this.cbLgota.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Тариф";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Льгота";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(510, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLgota);
            this.Controls.Add(this.cbTarif);
            this.Controls.Add(this.btnCreateAbonent);
            this.Controls.Add(this.labelPeople);
            this.Controls.Add(this.tbPeople);
            this.Controls.Add(this.labelSq);
            this.Controls.Add(this.tbSquare);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.labelSchet);
            this.Controls.Add(this.tbSchet);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSchet;
        private System.Windows.Forms.Label labelSchet;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label labelSq;
        private System.Windows.Forms.TextBox tbSquare;
        private System.Windows.Forms.Label labelPeople;
        private System.Windows.Forms.TextBox tbPeople;
        private System.Windows.Forms.Button btnCreateAbonent;
        private System.Windows.Forms.ComboBox cbTarif;
        private System.Windows.Forms.ComboBox cbLgota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}