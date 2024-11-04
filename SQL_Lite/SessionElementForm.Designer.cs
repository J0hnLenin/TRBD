namespace SQL_Lite
{
    partial class SessionElementForm
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
            this.hallComboBox = new System.Windows.Forms.ComboBox();
            this.sessionStartTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sessionStartTimeLabel = new System.Windows.Forms.Label();
            this.hallLabel = new System.Windows.Forms.Label();
            this.sessionDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.movieTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.sessionDateLabel = new System.Windows.Forms.Label();
            this.movieLabel = new System.Windows.Forms.Label();
            this.sessionFinishTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sessionFinishTimeLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.MaskedTextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.movieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hallComboBox
            // 
            this.hallComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "0+",
            "6+",
            "12+",
            "16+",
            "18+"});
            this.hallComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hallComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hallComboBox.FormattingEnabled = true;
            this.hallComboBox.Location = new System.Drawing.Point(173, 38);
            this.hallComboBox.Name = "hallComboBox";
            this.hallComboBox.Size = new System.Drawing.Size(95, 28);
            this.hallComboBox.TabIndex = 16;
            // 
            // sessionStartTimeTextBox
            // 
            this.sessionStartTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sessionStartTimeTextBox.Location = new System.Drawing.Point(173, 107);
            this.sessionStartTimeTextBox.Mask = "00:00";
            this.sessionStartTimeTextBox.Name = "sessionStartTimeTextBox";
            this.sessionStartTimeTextBox.Size = new System.Drawing.Size(95, 26);
            this.sessionStartTimeTextBox.TabIndex = 17;
            this.sessionStartTimeTextBox.ValidatingType = typeof(System.DateTime);
            this.sessionStartTimeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.sessionStartTimeTextBox_Validating);
            // 
            // sessionStartTimeLabel
            // 
            this.sessionStartTimeLabel.AutoSize = true;
            this.sessionStartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sessionStartTimeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sessionStartTimeLabel.Location = new System.Drawing.Point(12, 110);
            this.sessionStartTimeLabel.Name = "sessionStartTimeLabel";
            this.sessionStartTimeLabel.Size = new System.Drawing.Size(117, 20);
            this.sessionStartTimeLabel.TabIndex = 23;
            this.sessionStartTimeLabel.Text = "Время начала";
            // 
            // hallLabel
            // 
            this.hallLabel.AutoSize = true;
            this.hallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hallLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hallLabel.Location = new System.Drawing.Point(12, 41);
            this.hallLabel.Name = "hallLabel";
            this.hallLabel.Size = new System.Drawing.Size(39, 20);
            this.hallLabel.TabIndex = 22;
            this.hallLabel.Text = "Зал";
            // 
            // sessionDateTextBox
            // 
            this.sessionDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sessionDateTextBox.Location = new System.Drawing.Point(173, 72);
            this.sessionDateTextBox.Mask = "00/00/0000";
            this.sessionDateTextBox.Name = "sessionDateTextBox";
            this.sessionDateTextBox.Size = new System.Drawing.Size(95, 26);
            this.sessionDateTextBox.TabIndex = 15;
            this.sessionDateTextBox.ValidatingType = typeof(System.DateTime);
            this.sessionDateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.sessionDateTextBox_Validating);
            // 
            // movieTextBox
            // 
            this.movieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.movieTextBox.Location = new System.Drawing.Point(207, 8);
            this.movieTextBox.Name = "movieTextBox";
            this.movieTextBox.ReadOnly = true;
            this.movieTextBox.Size = new System.Drawing.Size(266, 26);
            this.movieTextBox.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelButton.Location = new System.Drawing.Point(12, 237);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(225, 30);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveButton.Location = new System.Drawing.Point(247, 237);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(228, 30);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // sessionDateLabel
            // 
            this.sessionDateLabel.AutoSize = true;
            this.sessionDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sessionDateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sessionDateLabel.Location = new System.Drawing.Point(12, 75);
            this.sessionDateLabel.Name = "sessionDateLabel";
            this.sessionDateLabel.Size = new System.Drawing.Size(104, 20);
            this.sessionDateLabel.TabIndex = 21;
            this.sessionDateLabel.Text = "Дата сеанса";
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.movieLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.movieLabel.Location = new System.Drawing.Point(12, 9);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(63, 20);
            this.movieLabel.TabIndex = 20;
            this.movieLabel.Text = "Фильм";
            // 
            // sessionFinishTimeTextBox
            // 
            this.sessionFinishTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sessionFinishTimeTextBox.Location = new System.Drawing.Point(173, 142);
            this.sessionFinishTimeTextBox.Mask = "00:00";
            this.sessionFinishTimeTextBox.Name = "sessionFinishTimeTextBox";
            this.sessionFinishTimeTextBox.ReadOnly = true;
            this.sessionFinishTimeTextBox.Size = new System.Drawing.Size(95, 26);
            this.sessionFinishTimeTextBox.TabIndex = 24;
            this.sessionFinishTimeTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // sessionFinishTimeLabel
            // 
            this.sessionFinishTimeLabel.AutoSize = true;
            this.sessionFinishTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sessionFinishTimeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sessionFinishTimeLabel.Location = new System.Drawing.Point(12, 145);
            this.sessionFinishTimeLabel.Name = "sessionFinishTimeLabel";
            this.sessionFinishTimeLabel.Size = new System.Drawing.Size(155, 20);
            this.sessionFinishTimeLabel.TabIndex = 25;
            this.sessionFinishTimeLabel.Text = "Время завершения";
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.costTextBox.Location = new System.Drawing.Point(173, 174);
            this.costTextBox.Mask = "0000.00";
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(95, 26);
            this.costTextBox.TabIndex = 26;
            this.costTextBox.ValidatingType = typeof(int);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.costLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.costLabel.Location = new System.Drawing.Point(12, 177);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(93, 20);
            this.costLabel.TabIndex = 27;
            this.costLabel.Text = "Стоимость";
            // 
            // movieButton
            // 
            this.movieButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.movieButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.movieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.movieButton.Location = new System.Drawing.Point(173, 6);
            this.movieButton.Name = "movieButton";
            this.movieButton.Size = new System.Drawing.Size(30, 30);
            this.movieButton.TabIndex = 28;
            this.movieButton.Text = "+";
            this.movieButton.UseVisualStyleBackColor = false;
            this.movieButton.Click += new System.EventHandler(this.movieButton_Click);
            // 
            // SessionElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 279);
            this.Controls.Add(this.movieButton);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.sessionFinishTimeTextBox);
            this.Controls.Add(this.sessionFinishTimeLabel);
            this.Controls.Add(this.hallComboBox);
            this.Controls.Add(this.sessionStartTimeTextBox);
            this.Controls.Add(this.sessionStartTimeLabel);
            this.Controls.Add(this.hallLabel);
            this.Controls.Add(this.sessionDateTextBox);
            this.Controls.Add(this.movieTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.sessionDateLabel);
            this.Controls.Add(this.movieLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SessionElementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сеанс";
            this.Load += new System.EventHandler(this.SessionElementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hallComboBox;
        private System.Windows.Forms.MaskedTextBox sessionStartTimeTextBox;
        private System.Windows.Forms.Label sessionStartTimeLabel;
        private System.Windows.Forms.Label hallLabel;
        private System.Windows.Forms.MaskedTextBox sessionDateTextBox;
        private System.Windows.Forms.MaskedTextBox movieTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label sessionDateLabel;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.MaskedTextBox sessionFinishTimeTextBox;
        private System.Windows.Forms.Label sessionFinishTimeLabel;
        private System.Windows.Forms.MaskedTextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button movieButton;
    }
}