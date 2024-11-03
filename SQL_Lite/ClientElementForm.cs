using Azure.Core;
using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Lite
{
    public partial class ClientElementForm : Form
    {
        int ID;
        bool newClient;
        public ClientElementForm(int id, bool newClient)
        {
            InitializeComponent();
            ID = id;
            this.newClient = newClient;
            if (!newClient)
            {
                string[,] parameters = { { "@id", ID.ToString() } };

                string query = SQL_Requests.SelectClietByID();
                (SqliteConnection connection, SqliteDataReader reader) = Database.Select(query, parameters);
                while (reader.Read())
                {
                    nameTextBox.Text = reader.GetValue(0).ToString();
                    birthdayTextBox.Text = reader.GetValue(1).ToString();
                }
                connection.Close();

                ticketsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                query = SQL_Requests.SelectClietTiketsByID();
                Database.FillDataGridView(ticketsDataGridView, query, parameters, 1);
                ticketsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                ticketsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void SaveClient()
        {
            if (newClient)
            {
                string query = SQL_Requests.InsertCliet();
                string[,]  parameters = {
                    { "@name", nameTextBox.Text},
                    { "@birthday", birthdayTextBox.Text}
                };
                Database.Change(query, parameters);
            }
            else
            {
                string query = SQL_Requests.UpdateCliet();
                string[,] parameters = {
                    { "@name", nameTextBox.Text},
                    { "@birthday", birthdayTextBox.Text},
                    { "@id", ID.ToString()}
                };
                Database.Change(query, parameters);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveClient();
            Close();
        }

        private void birthdayTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void birthdayTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Validation.Date(birthdayTextBox);
        }
    }
}
