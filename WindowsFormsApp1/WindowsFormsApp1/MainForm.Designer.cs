﻿using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NewEmploeeButton = new System.Windows.Forms.Button();
            this.EditEmploeeButton = new System.Windows.Forms.Button();
            this.DeleteEmploeeButton = new System.Windows.Forms.Button();
            this.NewJobButton = new System.Windows.Forms.Button();
            this.EditJobButton = new System.Windows.Forms.Button();
            this.DeleteJobButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snilsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn,
            this.snilsDataGridViewTextBoxColumn,
            this.passport_series,
            this.passport_number});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.dataGridView1.DataSource = this.employeeBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(52, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(837, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.employeeidDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.finishdateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.jobBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Location = new System.Drawing.Point(52, 304);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.Size = new System.Drawing.Size(837, 213);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_CellBeginEdit);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            this.dataGridView2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView2_Scroll);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.dataSet1;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.dataSet1;
            // 
            // NewEmploeeButton
            // 
            this.NewEmploeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.NewEmploeeButton.Location = new System.Drawing.Point(895, 12);
            this.NewEmploeeButton.Name = "NewEmploeeButton";
            this.NewEmploeeButton.Size = new System.Drawing.Size(183, 67);
            this.NewEmploeeButton.TabIndex = 2;
            this.NewEmploeeButton.Text = "Создать работника";
            this.NewEmploeeButton.UseVisualStyleBackColor = true;
            this.NewEmploeeButton.Click += new System.EventHandler(this.NewEmploeeButton_Click);
            // 
            // EditEmploeeButton
            // 
            this.EditEmploeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.EditEmploeeButton.Location = new System.Drawing.Point(895, 85);
            this.EditEmploeeButton.Name = "EditEmploeeButton";
            this.EditEmploeeButton.Size = new System.Drawing.Size(183, 67);
            this.EditEmploeeButton.TabIndex = 3;
            this.EditEmploeeButton.Text = "Редактировать работника";
            this.EditEmploeeButton.UseVisualStyleBackColor = true;
            this.EditEmploeeButton.Click += new System.EventHandler(this.EditEmploeeButton_Click);
            // 
            // DeleteEmploeeButton
            // 
            this.DeleteEmploeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.DeleteEmploeeButton.Location = new System.Drawing.Point(895, 158);
            this.DeleteEmploeeButton.Name = "DeleteEmploeeButton";
            this.DeleteEmploeeButton.Size = new System.Drawing.Size(183, 67);
            this.DeleteEmploeeButton.TabIndex = 4;
            this.DeleteEmploeeButton.Text = "Удалить работника";
            this.DeleteEmploeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmploeeButton.Click += new System.EventHandler(this.DeleteEmploeeButton_Click);
            // 
            // NewJobButton
            // 
            this.NewJobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.NewJobButton.Location = new System.Drawing.Point(895, 304);
            this.NewJobButton.Name = "NewJobButton";
            this.NewJobButton.Size = new System.Drawing.Size(183, 67);
            this.NewJobButton.TabIndex = 5;
            this.NewJobButton.Text = "Создать запись работ";
            this.NewJobButton.UseVisualStyleBackColor = true;
            this.NewJobButton.Click += new System.EventHandler(this.NewJobButton_Click);
            // 
            // EditJobButton
            // 
            this.EditJobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.EditJobButton.Location = new System.Drawing.Point(895, 377);
            this.EditJobButton.Name = "EditJobButton";
            this.EditJobButton.Size = new System.Drawing.Size(183, 67);
            this.EditJobButton.TabIndex = 6;
            this.EditJobButton.Text = "Редактировать запись работ";
            this.EditJobButton.UseVisualStyleBackColor = true;
            this.EditJobButton.Click += new System.EventHandler(this.EditJobButton_Click);
            // 
            // DeleteJobButton
            // 
            this.DeleteJobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.DeleteJobButton.Location = new System.Drawing.Point(895, 450);
            this.DeleteJobButton.Name = "DeleteJobButton";
            this.DeleteJobButton.Size = new System.Drawing.Size(183, 67);
            this.DeleteJobButton.TabIndex = 7;
            this.DeleteJobButton.Text = "Удалить запись работ";
            this.DeleteJobButton.UseVisualStyleBackColor = true;
            this.DeleteJobButton.Click += new System.EventHandler(this.DeleteJobButton_Click);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "id работника";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.FillWeight = 77.64597F;
            this.startdateDataGridViewTextBoxColumn.HeaderText = "Дата начала работ";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finishdateDataGridViewTextBoxColumn
            // 
            this.finishdateDataGridViewTextBoxColumn.DataPropertyName = "finish_date";
            this.finishdateDataGridViewTextBoxColumn.FillWeight = 88.32489F;
            this.finishdateDataGridViewTextBoxColumn.HeaderText = "Дата окончания работ";
            this.finishdateDataGridViewTextBoxColumn.Name = "finishdateDataGridViewTextBoxColumn";
            this.finishdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 134.0292F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 152.2842F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.FillWeight = 89.54311F;
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "inn";
            dataGridViewCellStyle3.Format = "N6";
            dataGridViewCellStyle3.NullValue = null;
            this.innDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.innDataGridViewTextBoxColumn.FillWeight = 89.54311F;
            this.innDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.innDataGridViewTextBoxColumn.MaxInputLength = 12;
            this.innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            this.innDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // snilsDataGridViewTextBoxColumn
            // 
            this.snilsDataGridViewTextBoxColumn.DataPropertyName = "snils";
            this.snilsDataGridViewTextBoxColumn.FillWeight = 89.54311F;
            this.snilsDataGridViewTextBoxColumn.HeaderText = "СНИЛС";
            this.snilsDataGridViewTextBoxColumn.MaxInputLength = 14;
            this.snilsDataGridViewTextBoxColumn.Name = "snilsDataGridViewTextBoxColumn";
            this.snilsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passport_series
            // 
            this.passport_series.DataPropertyName = "passport_series";
            this.passport_series.FillWeight = 89.54311F;
            this.passport_series.HeaderText = "Серия паспорта";
            this.passport_series.MaxInputLength = 20;
            this.passport_series.Name = "passport_series";
            this.passport_series.ReadOnly = true;
            // 
            // passport_number
            // 
            this.passport_number.DataPropertyName = "passport_number";
            this.passport_number.FillWeight = 89.54311F;
            this.passport_number.HeaderText = "Номер паспорта";
            this.passport_number.MaxInputLength = 20;
            this.passport_number.Name = "passport_number";
            this.passport_number.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1090, 545);
            this.Controls.Add(this.DeleteJobButton);
            this.Controls.Add(this.EditJobButton);
            this.Controls.Add(this.NewJobButton);
            this.Controls.Add(this.DeleteEmploeeButton);
            this.Controls.Add(this.EditEmploeeButton);
            this.Controls.Add(this.NewEmploeeButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private BindingSource employeeBindingSource1;
        private DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private Button NewEmploeeButton;
        private Button EditEmploeeButton;
        private Button DeleteEmploeeButton;
        private Button NewJobButton;
        private Button EditJobButton;
        private Button DeleteJobButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finishdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn snilsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passport_series;
        private DataGridViewTextBoxColumn passport_number;
    }

        
    
}

