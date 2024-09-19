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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.CellBeginEdit += new DataGridViewCellCancelEventHandler(dataGridView1_CellBeginEdit);
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
            dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);

            dataGridView2.CellBeginEdit += new DataGridViewCellCancelEventHandler(dataGridView2_CellBeginEdit);
            dataGridView2.CellEndEdit += new DataGridViewCellEventHandler(dataGridView2_CellEndEdit);
            dataGridView2.Scroll += new ScrollEventHandler(dataGridView2_Scroll);

            LoadFromXML();

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataSet1.Employee.AcceptChanges();
            dataGridView1.Update();

            SaveToXML();
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {

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

        private void SaveToXML()
        {
            string filePath = "Data.xml";
            dataSet1.WriteXml(filePath);
        }

        private void LoadFromXML()
        {
            string filePath = "Data.xml";
            dataSet1.Clear();
            dataSet1.ReadXml(filePath);
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataSet1.Job.AcceptChanges();
            dataGridView2.Update();

            SaveToXML();
        }

        private void dataGridView2_Scroll(object sender, ScrollEventArgs e)
        {

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

        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void NewEmploeeButton_Click(object sender, EventArgs e)
        {
            EmployeeEditForm editForm = new EmployeeEditForm(dataSet1, true);
            editForm.ShowDialog();
        }

        private void EditEmploeeButton_Click(object sender, EventArgs e)
        {
            long editId = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
            EmployeeEditForm editForm = new EmployeeEditForm(dataSet1, false, editId);
            editForm.ShowDialog();
        }

        private void DeleteEmploeeButton_Click(object sender, EventArgs e)
        {
            Int64 rowId = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
            DataRow[] rows = dataSet1.Job.Select($"employee_id = {rowId}");

            if (rows.Length == 0)
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                dataSet1.Employee.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Нельзя удались работника у которого имеются работы");
            }
        }

        private void NewJobButton_Click(object sender, EventArgs e)
        {

            long parrentId = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
            long editId = Convert.ToInt64(dataGridView2.CurrentRow.Cells[0].Value);
            JobEditForm editForm = new JobEditForm(dataSet1, true, parrentId);
            editForm.ShowDialog();
        }

        private void EditJobButton_Click(object sender, EventArgs e)
        {

            long parrentId = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
            long editId = Convert.ToInt64(dataGridView2.CurrentRow.Cells[0].Value);
            JobEditForm editForm = new JobEditForm(dataSet1, false, parrentId, editId);
            editForm.ShowDialog();
        }

        private void DeleteJobButton_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentRow.Index;
            dataSet1.Job.Rows.RemoveAt(rowIndex);
        }
    }
}
