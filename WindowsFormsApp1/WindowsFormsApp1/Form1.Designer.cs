using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewEmploeeButton = new System.Windows.Forms.Button();
            this.EditEmploeeButton = new System.Windows.Forms.Button();
            this.DeleteEmploeeButton = new System.Windows.Forms.Button();
            this.NewJobButton = new System.Windows.Forms.Button();
            this.EditJobButton = new System.Windows.Forms.Button();
            this.DeleteJobButton = new System.Windows.Forms.Button();
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn,
            this.snilsDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 210);
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
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.employeeidDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.finishdateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.jobBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(52, 247);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(689, 182);
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
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "id работника";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "Дата начала работ";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            // 
            // finishdateDataGridViewTextBoxColumn
            // 
            this.finishdateDataGridViewTextBoxColumn.DataPropertyName = "finish_date";
            this.finishdateDataGridViewTextBoxColumn.HeaderText = "Дата окончания работ";
            this.finishdateDataGridViewTextBoxColumn.Name = "finishdateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "inn";
            dataGridViewCellStyle7.Format = "N6";
            dataGridViewCellStyle7.NullValue = null;
            this.innDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.innDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.innDataGridViewTextBoxColumn.MaxInputLength = 12;
            this.innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            // 
            // snilsDataGridViewTextBoxColumn
            // 
            this.snilsDataGridViewTextBoxColumn.DataPropertyName = "snils";
            this.snilsDataGridViewTextBoxColumn.HeaderText = "СНИЛС";
            this.snilsDataGridViewTextBoxColumn.MaxInputLength = 14;
            this.snilsDataGridViewTextBoxColumn.Name = "snilsDataGridViewTextBoxColumn";
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Серия номер паспорта";
            this.passportDataGridViewTextBoxColumn.MaxInputLength = 11;
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.Width = 135;
            // 
            // NewEmploeeButton
            // 
            this.NewEmploeeButton.Location = new System.Drawing.Point(797, 31);
            this.NewEmploeeButton.Name = "NewEmploeeButton";
            this.NewEmploeeButton.Size = new System.Drawing.Size(183, 44);
            this.NewEmploeeButton.TabIndex = 2;
            this.NewEmploeeButton.Text = "Создать работника";
            this.NewEmploeeButton.UseVisualStyleBackColor = true;
            this.NewEmploeeButton.Click += new System.EventHandler(this.NewEmploeeButton_Click);
            // 
            // EditEmploeeButton
            // 
            this.EditEmploeeButton.Location = new System.Drawing.Point(797, 81);
            this.EditEmploeeButton.Name = "EditEmploeeButton";
            this.EditEmploeeButton.Size = new System.Drawing.Size(183, 44);
            this.EditEmploeeButton.TabIndex = 3;
            this.EditEmploeeButton.Text = "Редактировать работника";
            this.EditEmploeeButton.UseVisualStyleBackColor = true;
            this.EditEmploeeButton.Click += new System.EventHandler(this.EditEmploeeButton_Click);
            // 
            // DeleteEmploeeButton
            // 
            this.DeleteEmploeeButton.Location = new System.Drawing.Point(797, 131);
            this.DeleteEmploeeButton.Name = "DeleteEmploeeButton";
            this.DeleteEmploeeButton.Size = new System.Drawing.Size(183, 44);
            this.DeleteEmploeeButton.TabIndex = 4;
            this.DeleteEmploeeButton.Text = "Удалить работника";
            this.DeleteEmploeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmploeeButton.Click += new System.EventHandler(this.DeleteEmploeeButton_Click);
            // 
            // NewJobButton
            // 
            this.NewJobButton.Location = new System.Drawing.Point(797, 247);
            this.NewJobButton.Name = "NewJobButton";
            this.NewJobButton.Size = new System.Drawing.Size(183, 44);
            this.NewJobButton.TabIndex = 5;
            this.NewJobButton.Text = "Создать запись работ";
            this.NewJobButton.UseVisualStyleBackColor = true;
            this.NewJobButton.Click += new System.EventHandler(this.NewJobButton_Click);
            // 
            // EditJobButton
            // 
            this.EditJobButton.Location = new System.Drawing.Point(797, 297);
            this.EditJobButton.Name = "EditJobButton";
            this.EditJobButton.Size = new System.Drawing.Size(183, 44);
            this.EditJobButton.TabIndex = 6;
            this.EditJobButton.Text = "Редактировать запись работ";
            this.EditJobButton.UseVisualStyleBackColor = true;
            this.EditJobButton.Click += new System.EventHandler(this.EditJobButton_Click);
            // 
            // DeleteJobButton
            // 
            this.DeleteJobButton.Location = new System.Drawing.Point(797, 347);
            this.DeleteJobButton.Name = "DeleteJobButton";
            this.DeleteJobButton.Size = new System.Drawing.Size(183, 44);
            this.DeleteJobButton.TabIndex = 7;
            this.DeleteJobButton.Text = "Удалить запись работ";
            this.DeleteJobButton.UseVisualStyleBackColor = true;
            this.DeleteJobButton.Click += new System.EventHandler(this.DeleteJobButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 461);
            this.Controls.Add(this.DeleteJobButton);
            this.Controls.Add(this.EditJobButton);
            this.Controls.Add(this.NewJobButton);
            this.Controls.Add(this.DeleteEmploeeButton);
            this.Controls.Add(this.EditEmploeeButton);
            this.Controls.Add(this.NewEmploeeButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
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
        private DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private Button NewEmploeeButton;
        private Button EditEmploeeButton;
        private Button DeleteEmploeeButton;
        private Button NewJobButton;
        private Button EditJobButton;
        private Button DeleteJobButton;
    }

        
    
}

