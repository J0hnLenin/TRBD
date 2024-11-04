using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Lite
{
    internal class DataGridExtension
    {
        public static void FillDataGridView(DataGridView dataGridView, string request, string[,] requestParameters, int hiddenRows = 0)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            (SqliteConnection connection, SqliteDataReader reader) = Database.NoTransactionExecute(request, requestParameters);

            for (int i = 0; i < reader.FieldCount; i++)
            {
                dataGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                if (i < hiddenRows)
                {
                    dataGridView.Columns[reader.GetName(i)].Visible = false;
                }
            }

            while (reader.Read())
            {
                object[] rowData = new object[reader.FieldCount];
                reader.GetValues(rowData);
                dataGridView.Rows.Add(rowData);
            }

            connection.Close();
        }
        public static void SelectRowID(DataGridView dataGrid, int id, int hiddenRows)
        {            
            if(dataGrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.Cells[0].Value != null &&
                        Convert.ToInt32(row.Cells[0].Value) == id)
                    {

                        dataGrid.CurrentCell = row.Cells[hiddenRows];
                        row.Selected = true;
                        dataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
                DataGridViewRow firstRow = dataGrid.Rows[dataGrid.Rows.Count - 1];
                dataGrid.CurrentCell = firstRow.Cells[hiddenRows];
                firstRow.Selected = true;
                dataGrid.FirstDisplayedScrollingRowIndex = firstRow.Index;
            }
            
        }
        public static void UpdateDataGridView(DataGridView dataGrid, string query, string[,] queryParameters, int hiddenRows=1, int id=-1)
        {
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            FillDataGridView(dataGrid, query, queryParameters, hiddenRows);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SelectRowID(dataGrid, id, hiddenRows);
        }
    }
}
