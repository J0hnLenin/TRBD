namespace SQL_Lite
{
    partial class HallElementForm
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
            this.genreDeleteButton = new System.Windows.Forms.Button();
            this.genreAddButton = new System.Windows.Forms.Button();
            this.genresLabel = new System.Windows.Forms.Label();
            this.rowsDataGridView = new System.Windows.Forms.DataGridView();
            this.titleTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.sumSeatsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sumSeatsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rowsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // genreDeleteButton
            // 
            this.genreDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genreDeleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.genreDeleteButton.Location = new System.Drawing.Point(285, 168);
            this.genreDeleteButton.Name = "genreDeleteButton";
            this.genreDeleteButton.Size = new System.Drawing.Size(109, 53);
            this.genreDeleteButton.TabIndex = 25;
            this.genreDeleteButton.Text = "Удалить ряд";
            this.genreDeleteButton.UseVisualStyleBackColor = true;
            this.genreDeleteButton.Click += new System.EventHandler(this.rowDeleteButton_Click);
            // 
            // genreAddButton
            // 
            this.genreAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genreAddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.genreAddButton.Location = new System.Drawing.Point(285, 109);
            this.genreAddButton.Name = "genreAddButton";
            this.genreAddButton.Size = new System.Drawing.Size(109, 53);
            this.genreAddButton.TabIndex = 24;
            this.genreAddButton.Text = "Добавить ряд";
            this.genreAddButton.UseVisualStyleBackColor = true;
            this.genreAddButton.Click += new System.EventHandler(this.rowAddButton_Click);
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genresLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.genresLabel.Location = new System.Drawing.Point(12, 86);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(90, 20);
            this.genresLabel.TabIndex = 23;
            this.genresLabel.Text = "Ряды зала";
            // 
            // rowsDataGridView
            // 
            this.rowsDataGridView.AllowUserToAddRows = false;
            this.rowsDataGridView.AllowUserToDeleteRows = false;
            this.rowsDataGridView.AllowUserToResizeColumns = false;
            this.rowsDataGridView.AllowUserToResizeRows = false;
            this.rowsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rowsDataGridView.Location = new System.Drawing.Point(12, 109);
            this.rowsDataGridView.MultiSelect = false;
            this.rowsDataGridView.Name = "rowsDataGridView";
            this.rowsDataGridView.Size = new System.Drawing.Size(267, 191);
            this.rowsDataGridView.TabIndex = 22;
            this.rowsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.rowsDataGridView_CellFormatting);
            this.rowsDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.rowsDataGridView_CellValidated);
            this.rowsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.rowsDataGridView_CellValidating);
            this.rowsDataGridView.Validating += new System.ComponentModel.CancelEventHandler(this.rowsDataGridView_Validating);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleTextBox.Location = new System.Drawing.Point(130, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(149, 26);
            this.titleTextBox.TabIndex = 18;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelButton.Location = new System.Drawing.Point(12, 328);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(185, 30);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveButton.Location = new System.Drawing.Point(208, 328);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(186, 30);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titleLabel.Location = new System.Drawing.Point(12, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(83, 20);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "Название";
            // 
            // sumSeatsTextBox
            // 
            this.sumSeatsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sumSeatsTextBox.Location = new System.Drawing.Point(130, 44);
            this.sumSeatsTextBox.Name = "sumSeatsTextBox";
            this.sumSeatsTextBox.ReadOnly = true;
            this.sumSeatsTextBox.Size = new System.Drawing.Size(149, 26);
            this.sumSeatsTextBox.TabIndex = 26;
            // 
            // sumSeatsLabel
            // 
            this.sumSeatsLabel.AutoSize = true;
            this.sumSeatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sumSeatsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sumSeatsLabel.Location = new System.Drawing.Point(12, 47);
            this.sumSeatsLabel.Name = "sumSeatsLabel";
            this.sumSeatsLabel.Size = new System.Drawing.Size(112, 20);
            this.sumSeatsLabel.TabIndex = 27;
            this.sumSeatsLabel.Text = "Вместимость";
            // 
            // HallElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 370);
            this.Controls.Add(this.sumSeatsLabel);
            this.Controls.Add(this.sumSeatsTextBox);
            this.Controls.Add(this.genreDeleteButton);
            this.Controls.Add(this.genreAddButton);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.rowsDataGridView);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HallElementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зал";
            ((System.ComponentModel.ISupportInitialize)(this.rowsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genreDeleteButton;
        private System.Windows.Forms.Button genreAddButton;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.DataGridView rowsDataGridView;
        private System.Windows.Forms.MaskedTextBox titleTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.MaskedTextBox sumSeatsTextBox;
        private System.Windows.Forms.Label sumSeatsLabel;
    }
}