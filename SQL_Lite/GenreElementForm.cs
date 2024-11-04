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
    public partial class GenreElementForm : Form
    {
        int ID;
        bool newElement;
        public GenreElementForm(int id, bool newElement)
        {
            InitializeComponent();
            ID = id;
            this.newElement = newElement;
            if (!newElement)
            {
                string[,] parameters = { { "@id", ID.ToString() } };

                string query = SQL_Requests.SelectGenreByID();
                (SqliteConnection connection, SqliteDataReader reader) = Database.NoTransactionExecute(query, parameters);
                while (reader.Read())
                {
                    titleTextBox.Text = reader.GetValue(0).ToString();
                }
                connection.Close();
            }
        }

        private void SaveGenre()
        {
            if (newElement)
            {
                string query = SQL_Requests.InsertGenre();
                string[,] parameters = {
                    { "@genre_title", titleTextBox.Text}
                };
                Database.TransactionExecute(query, parameters);
            }
            else
            {
                string query = SQL_Requests.UpdateGenre();
                string[,] parameters = {
                    { "@genre_title", titleTextBox.Text},
                    { "@id", ID.ToString()}
                };
                Database.TransactionExecute(query, parameters);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveGenre();
            Close();
        }
    }
}
