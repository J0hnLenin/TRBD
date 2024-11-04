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
        bool newElement;

        public ClientElementForm(int id, bool newElement)
        {
            InitializeComponent();
            ID = id;
            this.newElement = newElement;
            if (!newElement)
            {
                string[,] parameters = { { "@id", ID.ToString() } };

                string query = SQL_Requests.SelectClietByID();
                (SqliteConnection connection, SqliteDataReader reader) = Database.NoTransactionExecute(query, parameters);
                while (reader.Read())
                {
                    nameTextBox.Text = reader.GetValue(0).ToString();
                    birthdayTextBox.Text = reader.GetValue(1).ToString();
                }
                connection.Close();

                DataGridExtension.UpdateDataGridView(ticketsDataGridView, SQL_Requests.SelectClietTiketsByID(), parameters);
            }
        }

        private void SaveClient()
        {
            if (newElement)
            {
                string query = SQL_Requests.InsertCliet();
                string[,]  parameters = {
                    { "@name", nameTextBox.Text},
                    { "@birthday", Validation.changeDateFormat(birthdayTextBox.Text)}
                };
                Database.TransactionExecute(query, parameters);
            }
            else
            {
                string query = SQL_Requests.UpdateCliet();
                string[,] parameters = {
                    { "@name", nameTextBox.Text},
                    { "@birthday", Validation.changeDateFormat(birthdayTextBox.Text)},
                    { "@id", ID.ToString()}
                };
                Database.TransactionExecute(query, parameters);
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

        private void nameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
