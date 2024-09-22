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
            this.label_start_date = new System.Windows.Forms.Label();
            this.label_finish_date = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.canselButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.id.Location = new System.Drawing.Point(49, 3);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 32);
            this.id.TabIndex = 0;
            this.id.Visible = false;
            // 
            // emploee_id
            // 
            this.emploee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.emploee_id.Location = new System.Drawing.Point(49, 38);
            this.emploee_id.Name = "emploee_id";
            this.emploee_id.Size = new System.Drawing.Size(0, 32);
            this.emploee_id.TabIndex = 1;
            this.emploee_id.Visible = false;
            // 
            // finish_date
            // 
            this.finish_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finish_date.Location = new System.Drawing.Point(231, 47);
            this.finish_date.Mask = "00/00/0000";
            this.finish_date.Name = "finish_date";
            this.finish_date.Size = new System.Drawing.Size(94, 27);
            this.finish_date.TabIndex = 2;
            this.finish_date.ValidatingType = typeof(System.DateTime);
            this.finish_date.Validating += new System.ComponentModel.CancelEventHandler(this.finish_date_Validating);
            // 
            // start_date
            // 
            this.start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_date.Location = new System.Drawing.Point(231, 12);
            this.start_date.Mask = "00/00/0000";
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(94, 27);
            this.start_date.TabIndex = 3;
            this.start_date.ValidatingType = typeof(System.DateTime);
            this.start_date.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.start_date_MaskInputRejected);
            this.start_date.Validating += new System.ComponentModel.CancelEventHandler(this.start_date_Validating);
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.Window;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(231, 84);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(285, 27);
            this.description.TabIndex = 4;
            // 
            // label_start_date
            // 
            this.label_start_date.AutoSize = true;
            this.label_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start_date.Location = new System.Drawing.Point(53, 15);
            this.label_start_date.Name = "label_start_date";
            this.label_start_date.Size = new System.Drawing.Size(172, 20);
            this.label_start_date.TabIndex = 7;
            this.label_start_date.Text = "Дата начала работ";
            this.label_start_date.Click += new System.EventHandler(this.label_start_date_Click);
            // 
            // label_finish_date
            // 
            this.label_finish_date.AutoSize = true;
            this.label_finish_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_finish_date.Location = new System.Drawing.Point(22, 50);
            this.label_finish_date.Name = "label_finish_date";
            this.label_finish_date.Size = new System.Drawing.Size(201, 20);
            this.label_finish_date.TabIndex = 8;
            this.label_finish_date.Text = "Дата окончания работ";
            this.label_finish_date.Click += new System.EventHandler(this.label_finish_date_Click);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_description.Location = new System.Drawing.Point(82, 87);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(146, 20);
            this.label_description.TabIndex = 9;
            this.label_description.Text = "Описание работ";
            this.label_description.Click += new System.EventHandler(this.label_description_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(281, 128);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 52);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // canselButton
            // 
            this.canselButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canselButton.Location = new System.Drawing.Point(139, 128);
            this.canselButton.Name = "canselButton";
            this.canselButton.Size = new System.Drawing.Size(136, 52);
            this.canselButton.TabIndex = 16;
            this.canselButton.Text = "Отменить изменения";
            this.canselButton.UseVisualStyleBackColor = true;
            this.canselButton.Click += new System.EventHandler(this.canselButton_Click);
            // 
            // JobEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 192);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.canselButton);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_finish_date);
            this.Controls.Add(this.label_start_date);
            this.Controls.Add(this.description);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.finish_date);
            this.Controls.Add(this.emploee_id);
            this.Controls.Add(this.id);
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

        private System.Windows.Forms.MaskedTextBox id;
        private System.Windows.Forms.MaskedTextBox emploee_id;
        private System.Windows.Forms.MaskedTextBox finish_date;
        private System.Windows.Forms.MaskedTextBox start_date;
        private System.Windows.Forms.MaskedTextBox description;
        private System.Windows.Forms.Label label_start_date;
        private System.Windows.Forms.Label label_finish_date;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button canselButton;
    }
}