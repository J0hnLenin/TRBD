namespace SQL_Lite
{
    partial class ClientElementForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ticketsDataGridView = new System.Windows.Forms.DataGridView();
            this.ticketsLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.birthdayTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "ФИО";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayLabel.Location = new System.Drawing.Point(12, 47);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(128, 20);
            this.birthdayLabel.TabIndex = 1;
            this.birthdayLabel.Text = "Дата рождения";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(328, 295);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(298, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(12, 295);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(301, 30);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ticketsDataGridView
            // 
            this.ticketsDataGridView.AllowUserToAddRows = false;
            this.ticketsDataGridView.AllowUserToDeleteRows = false;
            this.ticketsDataGridView.AllowUserToResizeColumns = false;
            this.ticketsDataGridView.AllowUserToResizeRows = false;
            this.ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDataGridView.Location = new System.Drawing.Point(12, 115);
            this.ticketsDataGridView.Name = "ticketsDataGridView";
            this.ticketsDataGridView.ReadOnly = true;
            this.ticketsDataGridView.Size = new System.Drawing.Size(614, 164);
            this.ticketsDataGridView.TabIndex = 6;
            // 
            // ticketsLabel
            // 
            this.ticketsLabel.AutoSize = true;
            this.ticketsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketsLabel.Location = new System.Drawing.Point(12, 92);
            this.ticketsLabel.Name = "ticketsLabel";
            this.ticketsLabel.Size = new System.Drawing.Size(135, 20);
            this.ticketsLabel.TabIndex = 7;
            this.ticketsLabel.Text = "Билеты клиента";
            this.ticketsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(158, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(247, 26);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nameTextBox_MaskInputRejected);
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayTextBox.Location = new System.Drawing.Point(158, 47);
            this.birthdayTextBox.Mask = "00/00/0000";
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(95, 26);
            this.birthdayTextBox.TabIndex = 2;
            this.birthdayTextBox.ValidatingType = typeof(System.DateTime);
            this.birthdayTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.birthdayTextBox_MaskInputRejected);
            this.birthdayTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.birthdayTextBox_Validating);
            // 
            // ClientElementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(638, 337);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ticketsLabel);
            this.Controls.Add(this.ticketsDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientElementForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView ticketsDataGridView;
        private System.Windows.Forms.Label ticketsLabel;
        private System.Windows.Forms.MaskedTextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox birthdayTextBox;
    }
}