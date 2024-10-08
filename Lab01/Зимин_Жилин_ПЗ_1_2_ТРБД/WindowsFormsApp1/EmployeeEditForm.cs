﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EmployeeEditForm : Form
    {
        Int64 editId;
        private DataSet1 dataSet1;
        public Int64 NewId;
        bool newEmployee;

        public EmployeeEditForm(DataSet1 dataSet1, bool newEmployee, Int64 editId=0)
        {
            InitializeComponent();
            this.editId = editId;
            this.dataSet1 = dataSet1;
            this.newEmployee = newEmployee;

            if (!newEmployee)
            {
                DataView dataView = dataSet1.Employee.AsDataView();
                dataView.RowFilter = $"id = {editId}";

                if (dataView.Count > 0)
                {
                    DataRowView row = dataView[0]; // Получаем первую строку
                    name.Text = row["name"].ToString();
                    birthday.Text = row["birthday"].ToString();
                    inn.Text = row["inn"].ToString();
                    snils.Text = row["snils"].ToString();
                    passport_series.Text = row["passport_series"].ToString();
                    passport_number.Text = row["passport_number"].ToString();
                }
            }
            

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void name_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void id_label_Click(object sender, EventArgs e)
        {

        }

        private void inn_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void birthday_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void passport_series_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void birthday_Validating(object sender, CancelEventArgs e)
        {
            string DateValue;
            DateTime DateFormated;

            DateValue = birthday.Text;
            if (DateValue != "  .  .")
            {
                if (!DateTime.TryParseExact(DateValue, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateFormated))
                {
                    birthday.Text = "  .  .";
                    CustomMessageBox box = new CustomMessageBox("        Неверно введена дата.\n" +
                                                                "      Вводите дату в формате\n" +
                                                                "              день.месяц.год");
                    box.ShowDialog();
                    e.Cancel = true;
                }
            }
            
        }

        private void SaveEmployee()
        {
            if (newEmployee)
            {
                DataRow newRow = dataSet1.Employee.NewRow();
                
                newRow["name"] = name.Text;
                if (birthday.Text != "  .  .")
                {
                    newRow["birthday"] = birthday.Text;
                }
                newRow["inn"] = inn.Text;
                newRow["snils"] = snils.Text;
                newRow["passport_series"] = passport_series.Text;
                newRow["passport_number"] = passport_number.Text;
                
                dataSet1.Employee.Rows.Add(newRow);

                dataSet1.Employee.AcceptChanges();
                NewId = Convert.ToInt64(newRow["id"].ToString());


            }
            else
            {
                DataRow[] rows = dataSet1.Employee.Select($"id = {editId}");

                if (rows.Length > 0)
                {
                    rows[0]["name"] = name.Text;
                    if(birthday.Text != "  .  .")
                    {
                        rows[0]["birthday"] = birthday.Text;
                    }
                    rows[0]["inn"] = inn.Text;
                    rows[0]["snils"] = snils.Text;
                    rows[0]["passport_series"] = passport_series.Text;
                    rows[0]["passport_number"] = passport_number.Text;

                    dataSet1.Employee.AcceptChanges();
                    NewId = editId;
                }

            }
        }

        private void EmployeeEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void canselButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveEmployee();
            this.Close();
        }
    }
}
