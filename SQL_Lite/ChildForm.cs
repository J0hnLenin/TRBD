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
        private string dataGridQuery = "";

        public ChildForm(ToolStripItemClickedEventArgs e)
        {

            InitializeComponent();
            
            Text = e.ClickedItem.Text;
            switch (e.ClickedItem.Name)
            {
                case "movieMenuItem":
                    Name = "movieTableForm";
                    dataGridQuery = SQL_Requests.SelectMovies();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                    break;
                case "sessionMenuItem":
                    Name = "sessionTableForm";
                    dataGridQuery = SQL_Requests.SelectSessions();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                    break;
                case "hallMenuItem":
                    Name = "hallTableForm";
                    dataGridQuery = SQL_Requests.SelectHalls();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                    break;
                case "ticketMenuItem":
                    Name = "ticketTableForm";
                    dataGridQuery = SQL_Requests.SelectTickets();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2], hiddenRows: 0);
                    break;
                case "clientMenuItem":
                    Name = "clientTableForm";
                    dataGridQuery = SQL_Requests.SelectClients();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                    break;
                case "genreMenuItem":
                    Name = "genreTableForm";
                    dataGridQuery = SQL_Requests.SelectGenres();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                    break;
            }
            
        }

        private void OpenElementForm(bool newElement)
        {
            int editID;
            if (newElement) {
                editID = -1;
            }
            else
            {
                editID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            }
            switch (Name)
            {
                case "movieTableForm":
                    MovieElementForm movieDialogForm = new MovieElementForm(editID, newElement);
                    movieDialogForm.ShowDialog();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2], id: editID);
                    break;
                case "sessionTableForm":
                    SessionElementForm sessionDialogForm = new SessionElementForm(editID, newElement);
                    sessionDialogForm.ShowDialog();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2], id: editID);
                    break;
                case "hallTableForm":
                    HallElementForm hallDialogForm = new HallElementForm(editID, newElement);
                    hallDialogForm.ShowDialog();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2], id: editID);
                    break;
                case "ticketTableForm":
                    TicketElementForm ticketDialogForm = new TicketElementForm(editID, newElement);
                    ticketDialogForm.ShowDialog();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2], hiddenRows: 0, id: editID);
                    break;
                case "clientTableForm":
                    ClientElementForm clientDialogForm = new ClientElementForm(editID, newElement);
                    clientDialogForm.ShowDialog();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2], id: editID);
                    break;
                case "genreTableForm":
                    GenreElementForm genreDialogForm = new GenreElementForm(editID, newElement);
                    genreDialogForm.ShowDialog();
                    DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2], id: editID);
                    break;
            }
            
        }
        private void ChildForm_Load(object sender, EventArgs e)
        {
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null)
                return;
            OpenElementForm(true);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null)
                return;
            OpenElementForm(false);
        }

        private void deleteBbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null)
                return;
            string tableName = Name.Substring(0, Name.Length-9);
            string query = SQL_Requests.DeleteByID(tableName);
            int deleteID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            string[,] parameters = { {"@id", deleteID.ToString()} };
            Database.TransactionExecute(query, parameters);
            DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
