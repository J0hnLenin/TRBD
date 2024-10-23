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
            dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void SelectRow(DataGridView dataGrid, int bIndex)
        {
            if (bIndex >= 0 && bIndex < dataGrid.Rows.Count)
            {
                dataGrid.CurrentCell = dataGrid.Rows[bIndex].Cells[2];
                dataGrid.Rows[bIndex].Selected = true;
                dataGrid.FirstDisplayedScrollingRowIndex = bIndex;
            }
        }

        private void SelectRowId(DataGridView dataGrid, Int64 id)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Value != null &&
                    Convert.ToInt32(row.Cells[0].Value) == id)
                {

                    dataGrid.CurrentCell = row.Cells[2];
                    row.Selected = true;
                    dataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }

        }
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

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
            dataSet1.Employee.AcceptChanges();
            dataSet1.Job.AcceptChanges();
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
            SaveToXML();

            SelectRowId(dataGridView1, editForm.NewId);
        }

        private void EditEmploeeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                long editId = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                EmployeeEditForm editForm = new EmployeeEditForm(dataSet1, false, editId);
                editForm.ShowDialog();
                SaveToXML();
            }
        }

        private void DeleteEmploeeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Int64 rowId = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                DataRow[] rows = dataSet1.Job.Select($"employee_id = {rowId}");

                if (rows.Length == 0)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    SaveToXML();
                    SelectRow(dataGridView1, 0);
                }
                else
                {
                    CustomMessageBox box = new CustomMessageBox("\n     Нельзя удались работника\n" +
                                                                "    у которого имеются работы");
                    box.ShowDialog();
                }
            }
        }

        private void NewJobButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                long parrentId = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                JobEditForm editForm = new JobEditForm(dataSet1, true, parrentId);
                editForm.ShowDialog();
                SaveToXML();

                SelectRowId(dataGridView2, editForm.NewId);
            }
        }

        private void EditJobButton_Click(object sender, EventArgs e)
        {
            if ((dataGridView2.CurrentRow != null) && (dataGridView1.CurrentRow != null))
            {
                long parrentId = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                long editId = Convert.ToInt64(dataGridView2.CurrentRow.Cells[0].Value);
                JobEditForm editForm = new JobEditForm(dataSet1, false, parrentId, editId);
                editForm.ShowDialog();
                SaveToXML();
            }
        }

        private void DeleteJobButton_Click(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentRow != null)
            {
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                SaveToXML();
                SelectRow(dataGridView2, 0);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToXML();
        }
    }
}
