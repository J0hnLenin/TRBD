using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MaskedTextBox maskedTextBox;
        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox = new MaskedTextBox();
            maskedTextBox.Visible = false;
            dataGridView1.Controls.Add(maskedTextBox);

            dataGridView1.CellBeginEdit += new DataGridViewCellCancelEventHandler(dataGridView1_CellBeginEdit);
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
            dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0: //id
                    maskedTextBox.Mask = "";
                    break;
                case 1: // name
                    maskedTextBox.Mask = "????????????????????????????????????????????????";
                    break;
                case 2: // birthday
                    maskedTextBox.Mask = "00/00/0000";
                    break;
                case 3: // inn
                    maskedTextBox.Mask = "000000000000";
                    break;
                case 4: // snils
                    maskedTextBox.Mask = "000-000-00 00";
                    break;
                case 5: // passport
                    maskedTextBox.Mask = "0000 000000";
                    break;
            }
            

            Rectangle rect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            maskedTextBox.Location = rect.Location;
            maskedTextBox.Size = rect.Size;
            maskedTextBox.Text = "";

            if (dataGridView1[e.ColumnIndex, e.RowIndex].Value != null)
            {
                maskedTextBox.Text = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            maskedTextBox.Visible = true;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (maskedTextBox.Visible)
            {
                dataGridView1.CurrentCell.Value = maskedTextBox.Text;
                maskedTextBox.Visible = false;
            }
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            if (maskedTextBox.Visible)
            {
                Rectangle rect = dataGridView1.GetCellDisplayRectangle(dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex,true);
                maskedTextBox.Location = rect.Location;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            
            //DataSet1.EmployeeDataTable EmployeesDataSet = new DataSet1.EmployeeDataTable();
            //dataGridView1.DataSource.ReadXml(filePath);

            //dataGridView1.DataSource = EmployeesDataSet;
            //dataGridView1.DataMember = "employees";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet1.EmployeeRow newEmployeeRow;

            newEmployeeRow = dataSet1.Employee.NewEmployeeRow();
            //newEmployeeRow.id = 5;
            newEmployeeRow.name = "Andrey";
            newEmployeeRow.birthday = DateTime.Today;
            newEmployeeRow.inn = "622420069801";
            newEmployeeRow.snils = "054-195-289 69";
            newEmployeeRow.passport = "3124 923423";

            // Add the row to the Region table
            dataSet1.Employee.Rows.Add(newEmployeeRow);

            // Save the new row to the database
            dataSet1.AcceptChanges();
            dataSet1.Employee.AcceptChanges();

            

            ///this.dataTa.Update(this.northwindDataSet.Region);
        }

        private void SaveTo_XML_Click(object sender, EventArgs e)
        {
            string filePath = "Data.xml";
            dataSet1.WriteXml(filePath);
        }

        private void LoadTo_XML_Click(object sender, EventArgs e)
        {
            string filePath = "Data.xml";
            dataSet1.Clear();
            dataSet1.ReadXml(filePath);
        }

        private void GenerateEmploee_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
        }
    }
}
