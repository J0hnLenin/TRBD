namespace WindowsFormsApp1
{
    partial class EmployeeEditForm
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
            this.name = new System.Windows.Forms.MaskedTextBox();
            this.birthday = new System.Windows.Forms.MaskedTextBox();
            this.inn = new System.Windows.Forms.MaskedTextBox();
            this.snils = new System.Windows.Forms.MaskedTextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.birthday_label = new System.Windows.Forms.Label();
            this.inn_label = new System.Windows.Forms.Label();
            this.snils_label = new System.Windows.Forms.Label();
            this.passport_series = new System.Windows.Forms.MaskedTextBox();
            this.passport_number = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(194, 46);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(241, 27);
            this.name.TabIndex = 1;
            this.name.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.name_MaskInputRejected);
            // 
            // birthday
            // 
            this.birthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthday.Location = new System.Drawing.Point(194, 80);
            this.birthday.Margin = new System.Windows.Forms.Padding(2);
            this.birthday.Mask = "00/00/0000";
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(241, 27);
            this.birthday.TabIndex = 2;
            this.birthday.ValidatingType = typeof(System.DateTime);
            this.birthday.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.birthday_MaskInputRejected);
            this.birthday.Validating += new System.ComponentModel.CancelEventHandler(this.birthday_Validating);
            // 
            // inn
            // 
            this.inn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inn.Location = new System.Drawing.Point(194, 111);
            this.inn.Margin = new System.Windows.Forms.Padding(2);
            this.inn.Mask = "000000000000";
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(241, 27);
            this.inn.TabIndex = 3;
            this.inn.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.inn_MaskInputRejected);
            // 
            // snils
            // 
            this.snils.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snils.Location = new System.Drawing.Point(194, 144);
            this.snils.Margin = new System.Windows.Forms.Padding(2);
            this.snils.Mask = "000-000-000 00";
            this.snils.Name = "snils";
            this.snils.Size = new System.Drawing.Size(241, 27);
            this.snils.TabIndex = 4;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(141, 53);
            this.name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 20);
            this.name_label.TabIndex = 5;
            this.name_label.Text = "ФИО";
            this.name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthday_label.Location = new System.Drawing.Point(49, 82);
            this.birthday_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(141, 20);
            this.birthday_label.TabIndex = 6;
            this.birthday_label.Text = "Дата рождения";
            // 
            // inn_label
            // 
            this.inn_label.AutoSize = true;
            this.inn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inn_label.Location = new System.Drawing.Point(144, 114);
            this.inn_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inn_label.Name = "inn_label";
            this.inn_label.Size = new System.Drawing.Size(46, 20);
            this.inn_label.TabIndex = 7;
            this.inn_label.Text = "ИНН";
            this.inn_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // snils_label
            // 
            this.snils_label.AutoSize = true;
            this.snils_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snils_label.Location = new System.Drawing.Point(121, 147);
            this.snils_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.snils_label.Name = "snils_label";
            this.snils_label.Size = new System.Drawing.Size(69, 20);
            this.snils_label.TabIndex = 8;
            this.snils_label.Text = "СНИЛС";
            // 
            // passport_series
            // 
            this.passport_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passport_series.Location = new System.Drawing.Point(194, 177);
            this.passport_series.Margin = new System.Windows.Forms.Padding(2);
            this.passport_series.Name = "passport_series";
            this.passport_series.Size = new System.Drawing.Size(241, 27);
            this.passport_series.TabIndex = 10;
            this.passport_series.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.passport_series_MaskInputRejected);
            // 
            // passport_number
            // 
            this.passport_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passport_number.Location = new System.Drawing.Point(194, 212);
            this.passport_number.Margin = new System.Windows.Forms.Padding(2);
            this.passport_number.Name = "passport_number";
            this.passport_number.Size = new System.Drawing.Size(241, 27);
            this.passport_number.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Серия паспорта";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Номер паспорта";
            // 
            // EmployeeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passport_number);
            this.Controls.Add(this.passport_series);
            this.Controls.Add(this.snils_label);
            this.Controls.Add(this.inn_label);
            this.Controls.Add(this.birthday_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.snils);
            this.Controls.Add(this.inn);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "EmployeeEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование информации о работнике";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeEditForm_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox name;
        private System.Windows.Forms.MaskedTextBox birthday;
        private System.Windows.Forms.MaskedTextBox inn;
        private System.Windows.Forms.MaskedTextBox snils;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label birthday_label;
        private System.Windows.Forms.Label inn_label;
        private System.Windows.Forms.Label snils_label;
        private System.Windows.Forms.MaskedTextBox passport_series;
        private System.Windows.Forms.MaskedTextBox passport_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}