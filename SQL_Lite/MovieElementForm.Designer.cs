namespace SQL_Lite
{
    partial class MovieElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieElementForm));
            this.releaseDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.titleTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.ageLimitLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ageLimitComboBox = new System.Windows.Forms.ComboBox();
            this.genresLabel = new System.Windows.Forms.Label();
            this.genresDataGridView = new System.Windows.Forms.DataGridView();
            this.genreAddButton = new System.Windows.Forms.Button();
            this.genreDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.genresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // releaseDateTextBox
            // 
            resources.ApplyResources(this.releaseDateTextBox, "releaseDateTextBox");
            this.releaseDateTextBox.Name = "releaseDateTextBox";
            this.releaseDateTextBox.ValidatingType = typeof(System.DateTime);
            this.releaseDateTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.releaseDateTextBox_MaskInputRejected);
            this.releaseDateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.releaseDateTextBox_Validating);
            // 
            // titleTextBox
            // 
            resources.ApplyResources(this.titleTextBox, "titleTextBox");
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.titleTextBox_MaskInputRejected);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // releaseDateLabel
            // 
            resources.ApplyResources(this.releaseDateLabel, "releaseDateLabel");
            this.releaseDateLabel.Name = "releaseDateLabel";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // ageLimitLabel
            // 
            resources.ApplyResources(this.ageLimitLabel, "ageLimitLabel");
            this.ageLimitLabel.Name = "ageLimitLabel";
            // 
            // durationLabel
            // 
            resources.ApplyResources(this.durationLabel, "durationLabel");
            this.durationLabel.Name = "durationLabel";
            // 
            // durationTextBox
            // 
            resources.ApplyResources(this.durationTextBox, "durationTextBox");
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.ValidatingType = typeof(System.DateTime);
            this.durationTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.durationTextBox_MaskInputRejected);
            this.durationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.durationTextBox_Validating);
            // 
            // ageLimitComboBox
            // 
            this.ageLimitComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("ageLimitComboBox.AutoCompleteCustomSource"),
            resources.GetString("ageLimitComboBox.AutoCompleteCustomSource1"),
            resources.GetString("ageLimitComboBox.AutoCompleteCustomSource2"),
            resources.GetString("ageLimitComboBox.AutoCompleteCustomSource3"),
            resources.GetString("ageLimitComboBox.AutoCompleteCustomSource4")});
            this.ageLimitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ageLimitComboBox, "ageLimitComboBox");
            this.ageLimitComboBox.FormattingEnabled = true;
            this.ageLimitComboBox.Items.AddRange(new object[] {
            resources.GetString("ageLimitComboBox.Items"),
            resources.GetString("ageLimitComboBox.Items1"),
            resources.GetString("ageLimitComboBox.Items2"),
            resources.GetString("ageLimitComboBox.Items3"),
            resources.GetString("ageLimitComboBox.Items4")});
            this.ageLimitComboBox.Name = "ageLimitComboBox";
            // 
            // genresLabel
            // 
            resources.ApplyResources(this.genresLabel, "genresLabel");
            this.genresLabel.Name = "genresLabel";
            // 
            // genresDataGridView
            // 
            this.genresDataGridView.AllowUserToAddRows = false;
            this.genresDataGridView.AllowUserToDeleteRows = false;
            this.genresDataGridView.AllowUserToResizeColumns = false;
            this.genresDataGridView.AllowUserToResizeRows = false;
            this.genresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.genresDataGridView, "genresDataGridView");
            this.genresDataGridView.Name = "genresDataGridView";
            this.genresDataGridView.ReadOnly = true;
            // 
            // genreAddButton
            // 
            resources.ApplyResources(this.genreAddButton, "genreAddButton");
            this.genreAddButton.Name = "genreAddButton";
            this.genreAddButton.UseVisualStyleBackColor = true;
            this.genreAddButton.Click += new System.EventHandler(this.genreAddButton_Click);
            // 
            // genreDeleteButton
            // 
            resources.ApplyResources(this.genreDeleteButton, "genreDeleteButton");
            this.genreDeleteButton.Name = "genreDeleteButton";
            this.genreDeleteButton.UseVisualStyleBackColor = true;
            this.genreDeleteButton.Click += new System.EventHandler(this.genreDeleteButton_Click);
            // 
            // MovieElementForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.genreDeleteButton);
            this.Controls.Add(this.genreAddButton);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.genresDataGridView);
            this.Controls.Add(this.ageLimitComboBox);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.ageLimitLabel);
            this.Controls.Add(this.releaseDateTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.releaseDateLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieElementForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.MovieElementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox releaseDateTextBox;
        private System.Windows.Forms.MaskedTextBox titleTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label releaseDateLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ageLimitLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.MaskedTextBox durationTextBox;
        private System.Windows.Forms.ComboBox ageLimitComboBox;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.DataGridView genresDataGridView;
        private System.Windows.Forms.Button genreAddButton;
        private System.Windows.Forms.Button genreDeleteButton;
    }
}