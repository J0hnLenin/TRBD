namespace SQL_Lite
{
    partial class ChildForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.createButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteBbutton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exitStripButton = new System.Windows.Forms.ToolStripButton();
            this.createStripButton = new System.Windows.Forms.ToolStripButton();
            this.editStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.searchStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.exportReportStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSWORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSEXELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.CausesValidation = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 30);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(752, 426);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(0, 0);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 7;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(0, 0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 6;
            // 
            // deleteBbutton
            // 
            this.deleteBbutton.Location = new System.Drawing.Point(0, 0);
            this.deleteBbutton.Name = "deleteBbutton";
            this.deleteBbutton.Size = new System.Drawing.Size(75, 23);
            this.deleteBbutton.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitStripButton,
            this.toolStripSeparator1,
            this.exportReportStripButton,
            this.createStripButton,
            this.editStripButton,
            this.deleteStripButton,
            this.toolStripSeparator2,
            this.searchStripLabel,
            this.searchTextBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(774, 29);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // exitStripButton
            // 
            this.exitStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exitStripButton.Image")));
            this.exitStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitStripButton.Name = "exitStripButton";
            this.exitStripButton.Size = new System.Drawing.Size(113, 26);
            this.exitStripButton.Text = "Закрыть окно";
            this.exitStripButton.Click += new System.EventHandler(this.exitStripButton_Click);
            // 
            // createStripButton
            // 
            this.createStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createStripButton.Image = ((System.Drawing.Image)(resources.GetObject("createStripButton.Image")));
            this.createStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createStripButton.Name = "createStripButton";
            this.createStripButton.Size = new System.Drawing.Size(72, 26);
            this.createStripButton.Text = "Создать";
            this.createStripButton.Click += new System.EventHandler(this.createStripButton_Click);
            // 
            // editStripButton
            // 
            this.editStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editStripButton.Image")));
            this.editStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editStripButton.Name = "editStripButton";
            this.editStripButton.Size = new System.Drawing.Size(121, 26);
            this.editStripButton.Text = "Редактировать";
            this.editStripButton.Click += new System.EventHandler(this.editStripButton_Click);
            // 
            // deleteStripButton
            // 
            this.deleteStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteStripButton.Image")));
            this.deleteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteStripButton.Name = "deleteStripButton";
            this.deleteStripButton.Size = new System.Drawing.Size(72, 26);
            this.deleteStripButton.Text = "Удалить";
            this.deleteStripButton.Click += new System.EventHandler(this.deleteStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // searchStripLabel
            // 
            this.searchStripLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchStripLabel.Name = "searchStripLabel";
            this.searchStripLabel.Size = new System.Drawing.Size(57, 26);
            this.searchStripLabel.Text = "Поиск:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(170, 29);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // exportReportStripButton
            // 
            this.exportReportStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportReportStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem,
            this.mSWORDToolStripMenuItem,
            this.mSEXELToolStripMenuItem});
            this.exportReportStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportReportStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exportReportStripButton.Image")));
            this.exportReportStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportReportStripButton.Name = "exportReportStripButton";
            this.exportReportStripButton.Size = new System.Drawing.Size(82, 26);
            this.exportReportStripButton.Text = "Экспорт";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // mSWORDToolStripMenuItem
            // 
            this.mSWORDToolStripMenuItem.Name = "mSWORDToolStripMenuItem";
            this.mSWORDToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.mSWORDToolStripMenuItem.Text = "MS WORD";
            this.mSWORDToolStripMenuItem.Click += new System.EventHandler(this.mSWORDToolStripMenuItem_Click);
            // 
            // mSEXELToolStripMenuItem
            // 
            this.mSEXELToolStripMenuItem.Name = "mSEXELToolStripMenuItem";
            this.mSEXELToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.mSEXELToolStripMenuItem.Text = "MS EXEL";
            this.mSEXELToolStripMenuItem.Click += new System.EventHandler(this.mSEXELToolStripMenuItem_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 469);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.deleteBbutton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChildForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChildForm";
            this.Load += new System.EventHandler(this.ChildForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteBbutton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exitStripButton;
        private System.Windows.Forms.ToolStripButton createStripButton;
        private System.Windows.Forms.ToolStripButton editStripButton;
        private System.Windows.Forms.ToolStripButton deleteStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel searchStripLabel;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.ToolStripDropDownButton exportReportStripButton;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSWORDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSEXELToolStripMenuItem;
    }
}