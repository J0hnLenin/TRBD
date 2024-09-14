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
            this.id_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(133, 39);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 26);
            this.id.TabIndex = 0;
            this.id.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(133, 76);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 26);
            this.name.TabIndex = 1;
            this.name.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.name_MaskInputRejected);
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(133, 108);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(100, 26);
            this.birthday.TabIndex = 2;
            // 
            // inn
            // 
            this.inn.Location = new System.Drawing.Point(133, 140);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(100, 26);
            this.inn.TabIndex = 3;
            // 
            // snils
            // 
            this.snils.Location = new System.Drawing.Point(133, 172);
            this.snils.Name = "snils";
            this.snils.Size = new System.Drawing.Size(100, 26);
            this.snils.TabIndex = 4;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(46, 42);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(81, 20);
            this.id_label.TabIndex = 5;
            this.id_label.Text = "Фамилия";
            this.id_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.snils);
            this.Controls.Add(this.inn);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox id;
        private System.Windows.Forms.MaskedTextBox name;
        private System.Windows.Forms.MaskedTextBox birthday;
        private System.Windows.Forms.MaskedTextBox inn;
        private System.Windows.Forms.MaskedTextBox snils;
        private System.Windows.Forms.Label id_label;
    }
}