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
    public partial class ClientSelectForm : Form
    {

        public string selectedClientID = "-1";
        public string selectedClientName = "";
        public bool success = false;

        public ClientSelectForm()
        {
            InitializeComponent();
            DataGridExtension.UpdateDataGridView(clientsDataGridView, SQL_Requests.SelectClients(), new string[0, 2]);
            clientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (clientsDataGridView.CurrentRow == null)
            {
                Close();
                return;
            }

            selectedClientID = clientsDataGridView.CurrentRow.Cells[0].Value?.ToString();
            selectedClientName = clientsDataGridView.CurrentRow.Cells[1].Value?.ToString();
            success = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
