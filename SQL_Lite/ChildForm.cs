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

namespace SQL_Lite
{
    public partial class ChildForm : Form
    {
        public ChildForm(ToolStripItemClickedEventArgs e)
        {
            InitializeComponent();
            this.Text = e.ClickedItem.Text;
            
            string query = "";
            switch (e.ClickedItem.Name)
            {
                case "movieMenuItem":
                    query = SQL_Requests.SelectMovies();
                    break;
                case "sessionMenuItem":
                    query = SQL_Requests.SelectSessions();
                    break;
                case "hallMenuItem":
                    query = SQL_Requests.SelectHalls();
                    break;
                case "ticketMenuItem":
                    query = SQL_Requests.SelectTickets();
                    break;
                case "clientMenuItem":
                    query = SQL_Requests.SelectClients();
                    break;
                case "genreMenuItem":
                    query = SQL_Requests.SelectGenres();
                    break;
            }

            Database.FillDataGridView(dataGridView, query);
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
