namespace WindowsFormsApp1
{
    partial class JobEditForm
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
            this.finish_date = new System.Windows.Forms.MaskedTextBox();
            this.start_date = new System.Windows.Forms.MaskedTextBox();
            this.description = new System.Windows.Forms.MaskedTextBox();
            this.label_start_date = new System.Windows.Forms.Label();
            this.label_finish_date = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finish_date
            // 
            this.finish_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.finish_date.Location = new System.Drawing.Point(215, 78);
            this.finish_date.Mask = "00/00/0000";
            this.finish_date.Name = "finish_date";
            this.finish_date.Size = new System.Drawing.Size(95, 27);
            this.finish_date.TabIndex = 2;
            this.finish_date.ValidatingType = typeof(System.DateTime);
            this.finish_date.Validating += new System.ComponentModel.CancelEventHandler(this.finish_date_Validating);
            // 
            // start_date
            // 
            this.start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.start_date.Location = new System.Drawing.Point(215, 42);
            this.start_date.Mask = "00/00/0000";
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(95, 27);
            this.start_date.TabIndex = 3;
            this.start_date.ValidatingType = typeof(System.DateTime);
            this.start_date.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.start_date_MaskInputRejected);
            this.start_date.Validating += new System.ComponentModel.CancelEventHandler(this.start_date_Validating);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.description.Location = new System.Drawing.Point(215, 109);
            this.description.Name = "description";
            this.description.ShortcutsEnabled = false;
            this.description.Size = new System.Drawing.Size(222, 27);
            this.description.TabIndex = 4;
            // 
            // label_start_date
            // 
            this.label_start_date.AutoSize = true;
            this.label_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_start_date.Location = new System.Drawing.Point(12, 45);
            this.label_start_date.Name = "label_start_date";
            this.label_start_date.Size = new System.Drawing.Size(170, 22);
            this.label_start_date.TabIndex = 7;
            this.label_start_date.Text = "Дата начала работ";
            this.label_start_date.Click += new System.EventHandler(this.label_start_date_Click);
            // 
            // label_finish_date
            // 
            this.label_finish_date.AutoSize = true;
            this.label_finish_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_finish_date.Location = new System.Drawing.Point(12, 78);
            this.label_finish_date.Name = "label_finish_date";
            this.label_finish_date.Size = new System.Drawing.Size(199, 22);
            this.label_finish_date.TabIndex = 8;
            this.label_finish_date.Text = "Дата окончания работ";
            this.label_finish_date.Click += new System.EventHandler(this.label_finish_date_Click);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_description.Location = new System.Drawing.Point(12, 112);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(146, 22);
            this.label_description.TabIndex = 9;
            this.label_description.Text = "Описание работ";
            this.label_description.Click += new System.EventHandler(this.label_description_Click);
            // 
            // JobEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 240);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_finish_date);
            this.Controls.Add(this.label_start_date);
            this.Controls.Add(this.description);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.finish_date);
            this.MaximizeBox = false;
            this.Name = "JobEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование работ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JobEditForm_FormClosed);
            this.Load += new System.EventHandler(this.JobEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox finish_date;
        private System.Windows.Forms.MaskedTextBox start_date;
        private System.Windows.Forms.MaskedTextBox description;
        private System.Windows.Forms.Label label_start_date;
        private System.Windows.Forms.Label label_finish_date;
        private System.Windows.Forms.Label label_description;
    }
}