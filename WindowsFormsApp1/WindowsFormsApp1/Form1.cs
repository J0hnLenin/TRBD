using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MaskedTextBox maskedTextBox1;
        MaskedTextBox maskedTextBox2;
        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox1.Visible = false;
            dataGridView1.Controls.Add(maskedTextBox1);

            dataGridView1.CellBeginEdit += new DataGridViewCellCancelEventHandler(dataGridView1_CellBeginEdit);
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
            dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);

            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox2.Visible = false;
            dataGridView2.Controls.Add(maskedTextBox2);

            dataGridView2.CellBeginEdit += new DataGridViewCellCancelEventHandler(dataGridView2_CellBeginEdit);
            dataGridView2.CellEndEdit += new DataGridViewCellEventHandler(dataGridView2_CellEndEdit);
            dataGridView2.Scroll += new ScrollEventHandler(dataGridView2_Scroll);

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0: //id
                    maskedTextBox1.Mask = "";
                    break;
                case 1: // name
                    maskedTextBox1.Mask = "????????????????????????????????????????????????";
                    break;
                case 2: // birthday
                    maskedTextBox1.Mask = "00/00/0000";
                    break;
                case 3: // inn
                    maskedTextBox1.Mask = "000000000000";
                    break;
                case 4: // snils
                    maskedTextBox1.Mask = "000-000-00 00";
                    break;
                case 5: // passport
                    maskedTextBox1.Mask = "0000 000000";
                    break;
            }
            

            Rectangle rect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            maskedTextBox1.Location = rect.Location;
            maskedTextBox1.Size = rect.Size;
            maskedTextBox1.Text = "";

            if (dataGridView1[e.ColumnIndex, e.RowIndex].Value != null)
            {
                maskedTextBox1.Text = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            maskedTextBox1.Visible = true;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (maskedTextBox1.Visible)
            {
                dataGridView1.CurrentCell.Value = maskedTextBox1.Text;
                maskedTextBox1.Visible = false;
            }

            dataSet1.Employee.AcceptChanges();
            dataGridView1.Update();
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            if (maskedTextBox1.Visible)
            {
                Rectangle rect = dataGridView1.GetCellDisplayRectangle(dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex,true);
                maskedTextBox1.Location = rect.Location;
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

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // fill emploee.id to job.emploee_id
            dataGridView2[1, e.RowIndex].Value = dataGridView1.CurrentRow.Cells[0].Value;
            switch (e.ColumnIndex)
            {
                case 0: // id
                    maskedTextBox2.Mask = "";
                    break;
                case 1: // emploee_id
                    maskedTextBox2.Mask = "";
                    break;
                case 2: // start_date
                    maskedTextBox2.Mask = "00/00/0000";
                    break;
                case 3: // finish_date
                    maskedTextBox2.Mask = "00/00/0000";
                    break;
                case 4: // descriprion
                    maskedTextBox2.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                    break;
            }

            Rectangle rect = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            maskedTextBox2.Location = rect.Location;
            maskedTextBox2.Size = rect.Size;
            maskedTextBox2.Text = "";

            if (dataGridView2[e.ColumnIndex, e.RowIndex].Value != null)
            {
                maskedTextBox2.Text = dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            maskedTextBox2.Visible = true;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (maskedTextBox2.Visible)
            {
                dataGridView2.CurrentCell.Value = maskedTextBox2.Text;
                maskedTextBox2.Visible = false;
            }

            dataSet1.Job.AcceptChanges();
            dataGridView2.Update();
        }

        private void dataGridView2_Scroll(object sender, ScrollEventArgs e)
        {
            if (maskedTextBox2.Visible)
            {
                Rectangle rect = dataGridView2.GetCellDisplayRectangle(dataGridView2.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex, true);
                maskedTextBox2.Location = rect.Location;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView2.DataSource != null)
            {
                dataGridView2.DataSource = dataSet1.Job;
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = String.Format("employee_id = {0}", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            }

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string DateValue;
                DateTime DateFormated;
                
                DateValue = maskedTextBox1.Text;
                if (!DateTime.TryParseExact(DateValue, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateFormated))
                {
                    MessageBox.Show("value should match dd/MM/yyyy format");
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                string DateValue;
                DateTime DateFormated;

                DateValue = maskedTextBox2.Text;
                if (!DateTime.TryParseExact(DateValue, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateFormated))
                {
                    MessageBox.Show("value should match dd/MM/yyyy format");
                    e.Cancel = true;
                }
            }
        }
    }
}
