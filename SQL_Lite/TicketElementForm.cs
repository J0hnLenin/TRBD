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
    public partial class TicketElementForm : Form
    {
        int ID;
        bool newElement;
        string clientID = "-1";
        string sessionID = "-1";
        public TicketElementForm(int id, bool newElement)
        {
            InitializeComponent();
            ID = id;
            this.newElement = newElement;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            ClientSelectForm clientDialogForm = new ClientSelectForm();
            clientDialogForm.ShowDialog();

            if (clientDialogForm.success)
            {
                clientID = clientDialogForm.selectedClientID;
                clientTextBox.Text = clientDialogForm.selectedClientName;
            }
        }

        private void sessionButton_Click(object sender, EventArgs e)
        {
            SessionSelectForm sessionDialogForm = new SessionSelectForm();
            sessionDialogForm.ShowDialog();

            if (sessionDialogForm.success)
            {
                sessionID = sessionDialogForm.selectedSessionID;
                sessionTextBox.Text = sessionDialogForm.selectedSessionName;
            }
        }
    }
}
