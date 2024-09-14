namespace WindowsFormsApp1
{
    partial class Form2
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
            this.id = new System.Windows.Forms.MaskedTextBox();
            this.name = new System.Windows.Forms.MaskedTextBox();
            this.birthday = new System.Windows.Forms.MaskedTextBox();
            this.inn = new System.Windows.Forms.MaskedTextBox();
            this.snils = new System.Windows.Forms.MaskedTextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.birthday_label = new System.Windows.Forms.Label();
            this.inn_label = new System.Windows.Forms.Label();
            this.snils_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.passport_series = new System.Windows.Forms.MaskedTextBox();
            this.passport_number = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(180, 36);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(271, 26);
            this.id.TabIndex = 0;
            this.id.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(180, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(271, 26);
            this.name.TabIndex = 1;
            this.name.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.name_MaskInputRejected);
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(180, 108);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(271, 26);
            this.birthday.TabIndex = 2;
            // 
            // inn
            // 
            this.inn.Location = new System.Drawing.Point(180, 140);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(271, 26);
            this.inn.TabIndex = 3;
            // 
            // snils
            // 
            this.snils.Location = new System.Drawing.Point(180, 175);
            this.snils.Name = "snils";
            this.snils.Size = new System.Drawing.Size(271, 26);
            this.snils.TabIndex = 4;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(127, 79);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(47, 20);
            this.name_label.TabIndex = 5;
            this.name_label.Text = "ФИО";
            this.name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.Location = new System.Drawing.Point(46, 114);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(128, 20);
            this.birthday_label.TabIndex = 6;
            this.birthday_label.Text = "Дата рождения";
            // 
            // inn_label
            // 
            this.inn_label.AutoSize = true;
            this.inn_label.Location = new System.Drawing.Point(130, 146);
            this.inn_label.Name = "inn_label";
            this.inn_label.Size = new System.Drawing.Size(44, 20);
            this.inn_label.TabIndex = 7;
            this.inn_label.Text = "ИНН";
            this.inn_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // snils_label
            // 
            this.snils_label.AutoSize = true;
            this.snils_label.Location = new System.Drawing.Point(108, 181);
            this.snils_label.Name = "snils_label";
            this.snils_label.Size = new System.Drawing.Size(66, 20);
            this.snils_label.TabIndex = 8;
            this.snils_label.Text = "СНИЛС";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(153, 42);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(21, 20);
            this.id_label.TabIndex = 9;
            this.id_label.Text = "id";
            this.id_label.Click += new System.EventHandler(this.id_label_Click);
            // 
            // passport_series
            // 
            this.passport_series.Location = new System.Drawing.Point(180, 207);
            this.passport_series.Name = "passport_series";
            this.passport_series.Size = new System.Drawing.Size(271, 26);
            this.passport_series.TabIndex = 10;
            // 
            // passport_number
            // 
            this.passport_number.Location = new System.Drawing.Point(180, 239);
            this.passport_number.Name = "passport_number";
            this.passport_number.Size = new System.Drawing.Size(271, 26);
            this.passport_number.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passport_number);
            this.Controls.Add(this.passport_series);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.snils_label);
            this.Controls.Add(this.inn_label);
            this.Controls.Add(this.birthday_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.snils);
            this.Controls.Add(this.inn);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox id;
        private System.Windows.Forms.MaskedTextBox name;
        private System.Windows.Forms.MaskedTextBox birthday;
        private System.Windows.Forms.MaskedTextBox inn;
        private System.Windows.Forms.MaskedTextBox snils;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label birthday_label;
        private System.Windows.Forms.Label inn_label;
        private System.Windows.Forms.Label snils_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.MaskedTextBox passport_series;
        private System.Windows.Forms.MaskedTextBox passport_number;
    }
}