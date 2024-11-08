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
    public partial class SessionSelectForm : Form
    {
        public string selectedSessionID = "-1";
        public string selectedSessionName = "";
        public string selectedHallID = "-1";
        public int selectedRows = -1;
        public int selectedMaxSeats = -1;
        public bool success = false;

        public SessionSelectForm()
        {
            InitializeComponent();
            DataGridExtension.UpdateDataGridView(sessionsDataGridView, SQL_Requests.SelectSessionsWithRows(), new string[0, 2], hiddenRows: 3);
            sessionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (sessionsDataGridView.CurrentRow == null)
            {
                Close();
                return;
            }

            selectedSessionID = sessionsDataGridView.CurrentRow.Cells[0].Value?.ToString();
            selectedRows = System.Int32.Parse(sessionsDataGridView.CurrentRow.Cells[1].Value?.ToString());
            selectedMaxSeats = System.Int32.Parse(sessionsDataGridView.CurrentRow.Cells[2].Value?.ToString());
            selectedHallID = sessionsDataGridView.CurrentRow.Cells[3].Value?.ToString();
            string movie = sessionsDataGridView.CurrentRow.Cells[4].Value?.ToString();
            string hall = sessionsDataGridView.CurrentRow.Cells[5].Value?.ToString();
            string date = sessionsDataGridView.CurrentRow.Cells[6].Value?.ToString();
            string start_time = sessionsDataGridView.CurrentRow.Cells[7].Value?.ToString();
            string finish_time = sessionsDataGridView.CurrentRow.Cells[8].Value?.ToString();
            selectedSessionName = string.Format("{0} {1} {2}-{3}", movie, date, start_time, finish_time);
            success = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
