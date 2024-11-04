using Microsoft.Data.Sqlite;
using System;
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
    public partial class SessionElementForm : Form
    {
        int ID = -1;
        string movieID = "-1";
        string duration = "00:00";
        bool newElement;
        private Dictionary<string, string> hallsIDS = new Dictionary<string, string>();
        public SessionElementForm(int id, bool newElement)
        {
            InitializeComponent();
            ID = id;
            this.newElement = newElement;
            string query = SQL_Requests.SelectHalls();
            (SqliteConnection connection, SqliteDataReader reader) = Database.NoTransactionExecute(query, new string[0, 2]);
            while (reader.Read())
            {
                string value = reader.GetValue(0).ToString();
                string key = reader.GetValue(1).ToString();
                hallsIDS.Add(key, value);
                hallComboBox.Items.Add(key);
            }
            connection.Close();

            if (!newElement)
            {
                string[,] parameters = { { "@id", ID.ToString() } };
                query = SQL_Requests.SelectSessionByID();
                (connection, reader) = Database.NoTransactionExecute(query, parameters);
                while (reader.Read())
                {
                    hallComboBox.Text = reader.GetValue(1).ToString();
                    movieID = reader.GetValue(2).ToString();
                    movieTextBox.Text = reader.GetValue(3).ToString();
                    sessionDateTextBox.Text = reader.GetValue(4).ToString();
                    sessionStartTimeTextBox.Text = reader.GetValue(5).ToString();
                    duration = reader.GetValue(6).ToString();
                    sessionFinishTimeTextBox.Text = Validation.addTime(sessionStartTimeTextBox.Text, duration);
                    costTextBox.Text = reader.GetValue(7).ToString();
                }
                connection.Close();
            }
        }

        private void SaveSession()
        {
            if (newElement)
            {
                string query = SQL_Requests.InsertSession();
                string[,] parameters = {
                    { "@hall_id", hallsIDS[hallComboBox.Text]},
                    { "@movie_id", movieID},
                    { "@start_time", string.Format("{0} {1}", 
                                     Validation.changeDateFormat(sessionDateTextBox.Text), 
                                     Validation.changeTimeFormat(sessionStartTimeTextBox.Text))},
                    { "@cost", costTextBox.Text}
                };
                Database.TransactionExecute(query, parameters);
            }
            else
            {
                string query = SQL_Requests.UpdateSession();
                string[,] parameters = {
                    { "@hall_id", hallsIDS[hallComboBox.Text]},
                    { "@movie_id", movieID},
                    { "@start_time", string.Format("{0} {1}",
                                     Validation.changeDateFormat(sessionDateTextBox.Text),
                                     Validation.changeTimeFormat(sessionStartTimeTextBox.Text))},
                    { "@cost", costTextBox.Text},
                    { "@id", ID.ToString()}
                };
                Database.TransactionExecute(query, parameters);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Validation.CheckFill("Фильм", movieID) && Validation.CheckFill("Зал", hallComboBox.Text))
            {
                SaveSession();
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SessionElementForm_Load(object sender, EventArgs e)
        {

        }

        private void sessionDateTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Validation.Date(sessionDateTextBox);
        }

        private void sessionStartTimeTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Validation.Time(sessionStartTimeTextBox);
            sessionFinishTimeTextBox.Text = Validation.addTime(sessionStartTimeTextBox.Text, duration);
        }

        private void movieButton_Click(object sender, EventArgs e)
        {
            MovieSelectForm movieDialogForm = new MovieSelectForm();
            movieDialogForm.ShowDialog();

            if (movieDialogForm.success)
            {
                movieID = movieDialogForm.selectedMovieID;
                movieTextBox.Text = movieDialogForm.selectedMovieTitle;
                duration = movieDialogForm.selectedDuration;
                sessionFinishTimeTextBox.Text = Validation.addTime(sessionStartTimeTextBox.Text, duration);
            }
        }
    }
}
