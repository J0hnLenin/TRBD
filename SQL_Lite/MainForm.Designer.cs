namespace SQL_Lite
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.objectStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceTableStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectStripMenuItem,
            this.referenceTableStripMenuItem,
            this.reportStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // objectStripMenuItem
            // 
            this.objectStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieStripTextBox});
            this.objectStripMenuItem.Name = "objectStripMenuItem";
            this.objectStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.objectStripMenuItem.Text = "Объекты";
            // 
            // referenceTableStripMenuItem
            // 
            this.referenceTableStripMenuItem.Name = "referenceTableStripMenuItem";
            this.referenceTableStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.referenceTableStripMenuItem.Text = "Справочные таблицы";
            // 
            // reportStripMenuItem
            // 
            this.reportStripMenuItem.Name = "reportStripMenuItem";
            this.reportStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reportStripMenuItem.Text = "Отчёты";
            // 
            // movieStripTextBox
            // 
            this.movieStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.movieStripTextBox.Name = "movieStripTextBox";
            this.movieStripTextBox.ReadOnly = true;
            this.movieStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.movieStripTextBox.Text = "Фильмы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Приложение";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem objectStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceTableStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox movieStripTextBox;
    }
}

