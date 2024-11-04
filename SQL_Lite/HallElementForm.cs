using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Lite
{
    public partial class HallElementForm : Form
    {
        int ID = -1;
        bool newElement;
        int maxx = 0;
        int summ = 0;
        public HallElementForm(int id, bool newElement)
        {
            InitializeComponent();
            ID = id;
            this.newElement = newElement;

            if (!newElement)
            {
                string[,] parameters = { { "@id", ID.ToString() } };

                string query = SQL_Requests.SelectHallByID();
                (SqliteConnection connection, SqliteDataReader reader) = Database.NoTransactionExecute(query, parameters);
                while (reader.Read())
                {
                    titleTextBox.Text = reader.GetValue(0).ToString();
                }
                connection.Close();
                DataGridExtension.UpdateDataGridView(rowsDataGridView, SQL_Requests.SelectHallRowsByID(), parameters);
            }
            else
            {
                rowsDataGridView.ColumnCount = 3;
                rowsDataGridView.ColumnHeadersVisible = true;
                rowsDataGridView.Columns[0].Name = "row_id";
                rowsDataGridView.Columns[0].Visible = false;
                rowsDataGridView.Columns[1].Name = "Номер ряда";
                rowsDataGridView.Columns[2].Name = "Количество мест";
                rowsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                rowsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            rowsDataGridView.Columns[0].ReadOnly = true;
            rowsDataGridView.Columns[1].ReadOnly = true;
            rowsDataGridView.Columns[2].ReadOnly = false;
            rowsDataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            rowsDataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            rowsDataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            updateDataGrid();
        }
        private void updateDataGrid()
        {
            summ = 0;
            maxx = 0;
            for(int i=0; i<rowsDataGridView.RowCount; i++) 
            {
                DataGridViewRow row = rowsDataGridView.Rows[i];
                summ += Int32.Parse(row.Cells[2].Value?.ToString());
                maxx = Math.Max(Int32.Parse(row.Cells[1].Value?.ToString()), maxx);
                row.Cells[1].Value = i + 1;
            }
            sumSeatsTextBox.Text = summ.ToString();
        }
        private void SaveHall()
        {
            if (newElement)
            {
                string query = SQL_Requests.InsertHall();
                string[,] parameters = { { "@hall_title", titleTextBox.Text} };
                ID = Database.TransactionExecute(query, parameters, needReturnID: true);
            }
            else
            {
                string query = SQL_Requests.UpdateHall();
                string[,] parameters = {
                    { "@hall_title", titleTextBox.Text},
                    { "@id", ID.ToString()}
                };
                Database.TransactionExecute(query, parameters);
            }
            if (ID != -1)
            {
                if (rowsDataGridView.RowCount > 0)
                {
                    string[,] parameters = { { "@id", ID.ToString() } };
                    string query = SQL_Requests.MultyplyDeleteRows();
                    Database.TransactionExecute(query, parameters);
                
                    query = SQL_Requests.InsertHallRows(rowsDataGridView.RowCount);
                    parameters = new string[3 * rowsDataGridView.RowCount, 2];

                    for (int i = 0; i < rowsDataGridView.RowCount; i++)
                    {
                        parameters[3 * i, 0] = String.Format("row_num_{0}", i);
                        parameters[3 * i, 1] = rowsDataGridView.Rows[i].Cells[1].Value?.ToString();
                        parameters[3 * i + 1, 0] = String.Format("num_seats_{0}", i);
                        parameters[3 * i + 1, 1] = rowsDataGridView.Rows[i].Cells[2].Value?.ToString();
                        parameters[3 * i + 2, 0] = String.Format("hall_id_{0}", i);
                        parameters[3 * i + 2, 1] = ID.ToString();
                    }
                    Database.TransactionExecute(query, parameters);
                }
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveHall();
            Close();
        }
        private void rowAddButton_Click(object sender, EventArgs e)
        {
            object[] newRow = new object[] {
                            "",
                            (maxx+1).ToString(),
                            "1"
                        };

            rowsDataGridView.Rows.Add(newRow);
        }
        private void rowDeleteButton_Click(object sender, EventArgs e)
        {
            if (rowsDataGridView.CurrentRow != null)
            {
                rowsDataGridView.Rows.RemoveAt(rowsDataGridView.CurrentRow.Index);
            }
            updateDataGrid();
        }

        private void rowsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            e.Cancel = !Validation.CheckInt(e.FormattedValue.ToString());
        }

        private void rowsDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            updateDataGrid();
        }

        private void rowsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void rowsDataGridView_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
