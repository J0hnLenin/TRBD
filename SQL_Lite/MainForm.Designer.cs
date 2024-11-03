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
            this.movieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceTableStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mainMenuStrip.Size = new System.Drawing.Size(1179, 29);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            this.mainMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenuStrip_ItemClicked);
            // 
            // objectStripMenuItem
            // 
            this.objectStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieMenuItem,
            this.hallMenuItem,
            this.sessionMenuItem,
            this.ticketMenuItem,
            this.clientMenuItem});
            this.objectStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.objectStripMenuItem.Name = "objectStripMenuItem";
            this.objectStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.objectStripMenuItem.Text = "Объекты";
            this.objectStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.objectStripMenuItem_DropDownItemClicked);
            this.objectStripMenuItem.Click += new System.EventHandler(this.objectStripMenuItem_Click);
            // 
            // movieMenuItem
            // 
            this.movieMenuItem.Name = "movieMenuItem";
            this.movieMenuItem.Size = new System.Drawing.Size(180, 26);
            this.movieMenuItem.Text = "Фильмы";
            this.movieMenuItem.Click += new System.EventHandler(this.movieMenuItem_Click);
            // 
            // hallMenuItem
            // 
            this.hallMenuItem.Name = "hallMenuItem";
            this.hallMenuItem.Size = new System.Drawing.Size(180, 26);
            this.hallMenuItem.Text = "Залы";
            // 
            // sessionMenuItem
            // 
            this.sessionMenuItem.Name = "sessionMenuItem";
            this.sessionMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sessionMenuItem.Text = "Сеансы";
            // 
            // ticketMenuItem
            // 
            this.ticketMenuItem.Name = "ticketMenuItem";
            this.ticketMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ticketMenuItem.Text = "Билеты";
            // 
            // clientMenuItem
            // 
            this.clientMenuItem.Name = "clientMenuItem";
            this.clientMenuItem.Size = new System.Drawing.Size(180, 26);
            this.clientMenuItem.Text = "Клиенты";
            // 
            // referenceTableStripMenuItem
            // 
            this.referenceTableStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreMenuItem});
            this.referenceTableStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.referenceTableStripMenuItem.Name = "referenceTableStripMenuItem";
            this.referenceTableStripMenuItem.Size = new System.Drawing.Size(178, 25);
            this.referenceTableStripMenuItem.Text = "Справочные таблицы";
            this.referenceTableStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.referenceTableStripMenuItem_DropDownItemClicked);
            this.referenceTableStripMenuItem.Click += new System.EventHandler(this.referenceTableStripMenuItem_Click);
            // 
            // genreMenuItem
            // 
            this.genreMenuItem.Name = "genreMenuItem";
            this.genreMenuItem.Size = new System.Drawing.Size(131, 26);
            this.genreMenuItem.Text = "Жанры";
            this.genreMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // reportStripMenuItem
            // 
            this.reportStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reportStripMenuItem.Name = "reportStripMenuItem";
            this.reportStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.reportStripMenuItem.Text = "Отчёты";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 616);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Система управления кинотеатром";
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
        private System.Windows.Forms.ToolStripMenuItem movieMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreMenuItem;
    }
}

