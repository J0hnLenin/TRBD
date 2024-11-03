using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;

namespace SQL_Lite
{
    public partial class ChildForm : Form
    {
        public ChildForm(ToolStripItemClickedEventArgs e)
        {

            InitializeComponent();
            this.dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Text = e.ClickedItem.Text;

            string query = "";
            switch (e.ClickedItem.Name)
            {
                case "movieMenuItem":
                    this.Name = "movieTableForm";
                    query = SQL_Requests.SelectMovies();
                    break;
                case "sessionMenuItem":
                    this.Name = "sessionTableForm";
                    query = SQL_Requests.SelectSessions();
                    break;
                case "hallMenuItem":
                    this.Name = "hallTableForm";
                    query = SQL_Requests.SelectHalls();
                    break;
                case "ticketMenuItem":
                    this.Name = "ticketTableForm";
                    query = SQL_Requests.SelectTickets();
                    break;
                case "clientMenuItem":
                    this.Name = "clientTableForm";
                    query = SQL_Requests.SelectClients();
                    break;
                case "genreMenuItem":
                    this.Name = "genreTableForm";
                    query = SQL_Requests.SelectGenres();
                    break;
            }

            Database.FillDataGridView(dataGridView, query, new string[0,2], 1);
            this.dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void OpenElementForm(bool newElement)
        {
            int editID;
            if (newElement) {
                editID = 0;
            }
            else
            {
                editID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            }
            switch (this.Name)
            {
                case "movieTableForm":
                    //ClientElementForm movieDialogForm = new ClientElementForm();
                    //movieDialogForm.ShowDialog();
                    break;
                case "sessionTableForm":
                    //ClientElementForm sessionDialogForm = new ClientElementForm();
                    //sessionDialogForm.ShowDialog();
                    break;
                case "hallTableForm":
                    //ClientElementForm hallDialogForm = new ClientElementForm();
                    //hallDialogForm.ShowDialog();
                    break;
                case "ticketTableForm":
                    //ClientElementForm ticketDialogForm = new ClientElementForm();
                    //ticketDialogForm.ShowDialog();
                    break;
                case "clientTableForm":
                    
                    ClientElementForm clientDialogForm = new ClientElementForm(editID, newElement);
                    clientDialogForm.ShowDialog();
                    break;
                case "genreTableForm":
                    //ClientElementForm genreDialogForm = new ClientElementForm();
                    //genreDialogForm.ShowDialog();
                    break;
            }
        }
        private void ChildForm_Load(object sender, EventArgs e)
        {
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            OpenElementForm(true);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            OpenElementForm(false);
        }

        private void deleteBbutton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
