namespace SQL_Lite
{
    partial class TicketElementForm
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
            this.clientButton = new System.Windows.Forms.Button();
            this.purcaseTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clientTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.purcaseTimeLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.sessionButton = new System.Windows.Forms.Button();
            this.sessionTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sessionLabel = new System.Windows.Forms.Label();
            this.rowTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rowLabel = new System.Windows.Forms.Label();
            this.seatTextBox = new System.Windows.Forms.MaskedTextBox();
            this.seatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientButton
            // 
            this.clientButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clientButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.clientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clientButton.Location = new System.Drawing.Point(121, 11);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(30, 30);
            this.clientButton.TabIndex = 35;
            this.clientButton.Text = "+";
            this.clientButton.UseVisualStyleBackColor = false;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // purcaseTimeTextBox
            // 
            this.purcaseTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.purcaseTimeTextBox.Location = new System.Drawing.Point(155, 80);
            this.purcaseTimeTextBox.Mask = "00/00/0000 90:00";
            this.purcaseTimeTextBox.Name = "purcaseTimeTextBox";
            this.purcaseTimeTextBox.ReadOnly = true;
            this.purcaseTimeTextBox.Size = new System.Drawing.Size(147, 26);
            this.purcaseTimeTextBox.TabIndex = 30;
            this.purcaseTimeTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // clientTextBox
            // 
            this.clientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clientTextBox.Location = new System.Drawing.Point(155, 13);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.ReadOnly = true;
            this.clientTextBox.Size = new System.Drawing.Size(456, 26);
            this.clientTextBox.TabIndex = 29;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelButton.Location = new System.Drawing.Point(12, 408);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(296, 30);
            this.cancelButton.TabIndex = 32;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveButton.Location = new System.Drawing.Point(315, 408);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(296, 30);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // purcaseTimeLabel
            // 
            this.purcaseTimeLabel.AutoSize = true;
            this.purcaseTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.purcaseTimeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.purcaseTimeLabel.Location = new System.Drawing.Point(12, 83);
            this.purcaseTimeLabel.Name = "purcaseTimeLabel";
            this.purcaseTimeLabel.Size = new System.Drawing.Size(111, 20);
            this.purcaseTimeLabel.TabIndex = 34;
            this.purcaseTimeLabel.Text = "Дата покупки";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clientLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientLabel.Location = new System.Drawing.Point(12, 13);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(65, 20);
            this.clientLabel.TabIndex = 33;
            this.clientLabel.Text = "Клиент";
            // 
            // sessionButton
            // 
            this.sessionButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sessionButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.sessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sessionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sessionButton.Location = new System.Drawing.Point(121, 44);
            this.sessionButton.Name = "sessionButton";
            this.sessionButton.Size = new System.Drawing.Size(30, 30);
            this.sessionButton.TabIndex = 38;
            this.sessionButton.Text = "+";
            this.sessionButton.UseVisualStyleBackColor = false;
            this.sessionButton.Click += new System.EventHandler(this.sessionButton_Click);
            // 
            // sessionTextBox
            // 
            this.sessionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sessionTextBox.Location = new System.Drawing.Point(155, 46);
            this.sessionTextBox.Name = "sessionTextBox";
            this.sessionTextBox.ReadOnly = true;
            this.sessionTextBox.Size = new System.Drawing.Size(456, 26);
            this.sessionTextBox.TabIndex = 36;
            // 
            // sessionLabel
            // 
            this.sessionLabel.AutoSize = true;
            this.sessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sessionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sessionLabel.Location = new System.Drawing.Point(12, 45);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(55, 20);
            this.sessionLabel.TabIndex = 37;
            this.sessionLabel.Text = "Сеанс";
            // 
            // rowTextBox
            // 
            this.rowTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rowTextBox.Location = new System.Drawing.Point(382, 80);
            this.rowTextBox.Mask = "00000";
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.ReadOnly = true;
            this.rowTextBox.Size = new System.Drawing.Size(80, 26);
            this.rowTextBox.TabIndex = 39;
            this.rowTextBox.ValidatingType = typeof(int);
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rowLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rowLabel.Location = new System.Drawing.Point(337, 83);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(39, 20);
            this.rowLabel.TabIndex = 40;
            this.rowLabel.Text = "Ряд";
            // 
            // seatTextBox
            // 
            this.seatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.seatTextBox.Location = new System.Drawing.Point(531, 80);
            this.seatTextBox.Mask = "00000";
            this.seatTextBox.Name = "seatTextBox";
            this.seatTextBox.ReadOnly = true;
            this.seatTextBox.Size = new System.Drawing.Size(80, 26);
            this.seatTextBox.TabIndex = 41;
            this.seatTextBox.ValidatingType = typeof(int);
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.seatLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.seatLabel.Location = new System.Drawing.Point(468, 83);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(57, 20);
            this.seatLabel.TabIndex = 42;
            this.seatLabel.Text = "Место";
            // 
            // TicketElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.seatTextBox);
            this.Controls.Add(this.seatLabel);
            this.Controls.Add(this.rowTextBox);
            this.Controls.Add(this.rowLabel);
            this.Controls.Add(this.sessionButton);
            this.Controls.Add(this.sessionTextBox);
            this.Controls.Add(this.sessionLabel);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.purcaseTimeTextBox);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.purcaseTimeLabel);
            this.Controls.Add(this.clientLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketElementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Билет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.MaskedTextBox purcaseTimeTextBox;
        private System.Windows.Forms.MaskedTextBox clientTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label purcaseTimeLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Button sessionButton;
        private System.Windows.Forms.MaskedTextBox sessionTextBox;
        private System.Windows.Forms.Label sessionLabel;
        private System.Windows.Forms.MaskedTextBox rowTextBox;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.MaskedTextBox seatTextBox;
        private System.Windows.Forms.Label seatLabel;
    }
}