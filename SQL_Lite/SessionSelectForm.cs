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
        public bool success = false;

        public SessionSelectForm()
        {
            InitializeComponent();
            DataGridExtension.UpdateDataGridView(sessionsDataGridView, SQL_Requests.SelectSessions(), new string[0, 2]);
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
            string movie = sessionsDataGridView.CurrentRow.Cells[1].Value?.ToString();
            string hall = sessionsDataGridView.CurrentRow.Cells[2].Value?.ToString();
            string date = sessionsDataGridView.CurrentRow.Cells[3].Value?.ToString();
            string start_time = sessionsDataGridView.CurrentRow.Cells[4].Value?.ToString();
            string finish_time = sessionsDataGridView.CurrentRow.Cells[5].Value?.ToString();
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
