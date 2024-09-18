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
            this.id = new System.Windows.Forms.MaskedTextBox();
            this.emploee_id = new System.Windows.Forms.MaskedTextBox();
            this.finish_date = new System.Windows.Forms.MaskedTextBox();
            this.start_date = new System.Windows.Forms.MaskedTextBox();
            this.description = new System.Windows.Forms.MaskedTextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_emploee_id = new System.Windows.Forms.Label();
            this.label_start_date = new System.Windows.Forms.Label();
            this.label_finish_date = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(163, 39);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 0;
            // 
            // emploee_id
            // 
            this.emploee_id.Location = new System.Drawing.Point(163, 65);
            this.emploee_id.Name = "emploee_id";
            this.emploee_id.Size = new System.Drawing.Size(100, 20);
            this.emploee_id.TabIndex = 1;
            // 
            // finish_date
            // 
            this.finish_date.Location = new System.Drawing.Point(163, 117);
            this.finish_date.Mask = "00/00/0000";
            this.finish_date.Name = "finish_date";
            this.finish_date.Size = new System.Drawing.Size(100, 20);
            this.finish_date.TabIndex = 2;
            this.finish_date.ValidatingType = typeof(System.DateTime);
            // 
            // start_date
            // 
            this.start_date.Location = new System.Drawing.Point(163, 91);
            this.start_date.Mask = "00/00/0000";
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(100, 20);
            this.start_date.TabIndex = 3;
            this.start_date.ValidatingType = typeof(System.DateTime);
            this.start_date.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.start_date_MaskInputRejected);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(163, 143);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(100, 20);
            this.description.TabIndex = 4;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(142, 42);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(15, 13);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "id";
            // 
            // label_emploee_id
            // 
            this.label_emploee_id.AutoSize = true;
            this.label_emploee_id.Location = new System.Drawing.Point(96, 68);
            this.label_emploee_id.Name = "label_emploee_id";
            this.label_emploee_id.Size = new System.Drawing.Size(61, 13);
            this.label_emploee_id.TabIndex = 6;
            this.label_emploee_id.Text = "id_emploee";
            this.label_emploee_id.Click += new System.EventHandler(this.label_emploee_id_Click);
            // 
            // label_start_date
            // 
            this.label_start_date.AutoSize = true;
            this.label_start_date.Location = new System.Drawing.Point(54, 94);
            this.label_start_date.Name = "label_start_date";
            this.label_start_date.Size = new System.Drawing.Size(103, 13);
            this.label_start_date.TabIndex = 7;
            this.label_start_date.Text = "Дата начала работ";
            this.label_start_date.Click += new System.EventHandler(this.label_start_date_Click);
            // 
            // label_finish_date
            // 
            this.label_finish_date.AutoSize = true;
            this.label_finish_date.Location = new System.Drawing.Point(36, 120);
            this.label_finish_date.Name = "label_finish_date";
            this.label_finish_date.Size = new System.Drawing.Size(121, 13);
            this.label_finish_date.TabIndex = 8;
            this.label_finish_date.Text = "Дата окончания работ";
            this.label_finish_date.Click += new System.EventHandler(this.label_finish_date_Click);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(68, 146);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(89, 13);
            this.label_description.TabIndex = 9;
            this.label_description.Text = "Описание работ";
            this.label_description.Click += new System.EventHandler(this.label_description_Click);
            // 
            // JobEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 215);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_finish_date);
            this.Controls.Add(this.label_start_date);
            this.Controls.Add(this.label_emploee_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.description);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.finish_date);
            this.Controls.Add(this.emploee_id);
            this.Controls.Add(this.id);
            this.MaximizeBox = false;
            this.Name = "JobEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование работ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox id;
        private System.Windows.Forms.MaskedTextBox emploee_id;
        private System.Windows.Forms.MaskedTextBox finish_date;
        private System.Windows.Forms.MaskedTextBox start_date;
        private System.Windows.Forms.MaskedTextBox description;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_emploee_id;
        private System.Windows.Forms.Label label_start_date;
        private System.Windows.Forms.Label label_finish_date;
        private System.Windows.Forms.Label label_description;
    }
}