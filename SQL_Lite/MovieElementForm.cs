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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Lite
{
    public partial class MovieElementForm : Form
    {
        int ID = -1;
        bool newElement;
        private Dictionary<string, DataGridViewRow>hiddenRows = new Dictionary<string, DataGridViewRow>();
        int alreadyExistGenres = 0;
        public MovieElementForm(int id, bool newElement)
        {
            InitializeComponent();
            ID = id;
            this.newElement = newElement;

            
            if (!newElement)
            {
                string[,] parameters = { { "@id", ID.ToString() } };

                string query = SQL_Requests.SelectMovieByID();
                (SqliteConnection connection, SqliteDataReader reader) = Database.NoTransactionExecute(query, parameters);
                while (reader.Read())
                {
                    titleTextBox.Text = reader.GetValue(0).ToString();
                    releaseDateTextBox.Text = reader.GetValue(1).ToString();
                    ageLimitComboBox.Text = reader.GetValue(2).ToString();
                    durationTextBox.Text = reader.GetValue(3).ToString();
                }
                connection.Close();
                DataGridExtension.UpdateDataGridView(genresDataGridView, SQL_Requests.SelectMovieGenresByID(), parameters, hiddenRows: 2);
                alreadyExistGenres = genresDataGridView.RowCount;
            }
            else
            {
                ageLimitComboBox.Text = "0+";
                genresDataGridView.ColumnCount = 3;
                genresDataGridView.ColumnHeadersVisible = true;
                genresDataGridView.Columns[0].Name = "movie_genre_id";
                genresDataGridView.Columns[0].Visible = false;
                genresDataGridView.Columns[1].Name = "genre_id";
                genresDataGridView.Columns[1].Visible = false;
                genresDataGridView.Columns[2].Name = "Жанр";
                genresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                genresDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            genresDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void SaveMovie()
        {
            if (newElement)
            {
                string query = SQL_Requests.InsertMovie();
                string[,] parameters = {
                    { "@movie_title", titleTextBox.Text},
                    { "@release_date", Validation.changeDateFormat(releaseDateTextBox.Text)},
                    { "@age_limit", ageLimitComboBox.Text.Replace("+", "")},
                    { "@duration", Validation.changeTimeFormat(durationTextBox.Text)}
                };
                ID = Database.TransactionExecute(query, parameters, needReturnID: true);
            }
            else
            {
                string query = SQL_Requests.UpdateMovie();
                string[,] parameters = {
                    { "@movie_title", titleTextBox.Text},
                    { "@release_date", Validation.changeDateFormat(releaseDateTextBox.Text)},
                    { "@age_limit", ageLimitComboBox.Text.Replace("+", "")},
                    { "@duration", Validation.changeTimeFormat(durationTextBox.Text)},
                    { "@id", ID.ToString()}
                };
                Database.TransactionExecute(query, parameters);
            }
            if (ID != -1)
            {
                // Добавляем новые
                int newRowsLength = genresDataGridView.Rows.Count - hiddenRows.Count - alreadyExistGenres;
                if (newRowsLength > 0)
                {
                    string query = SQL_Requests.InsertMovieGenres(newRowsLength);
                    string[,] parameters = new string[2 * newRowsLength, 2];
                    int j = 0;
                    for (int i = 0; i < genresDataGridView.Rows.Count; i++)
                    {
                        if (genresDataGridView.Rows[i].Visible && genresDataGridView.Rows[i].Cells[0].Value?.ToString() == "")
                        {
                            parameters[2 * j, 0] = String.Format("genre_id_{0}", j);
                            parameters[2 * j, 1] = genresDataGridView.Rows[i].Cells["genre_id"].Value?.ToString();
                            parameters[2 * j + 1, 0] = String.Format("movie_id_{0}", j);
                            parameters[2 * j + 1, 1] = ID.ToString();
                            j++;
                        }
                    }
                    Database.TransactionExecute(query, parameters);
                }

                // Убираем ненужные
                if (hiddenRows.Count > 0)
                {
                    string[] idToDelete = new string[hiddenRows.Count];
                    int i = 0;
                    foreach (DataGridViewRow row in hiddenRows.Values)
                    {
                        idToDelete[i] = row.Cells[0].Value?.ToString();
                        i++;
                    }
                    string query = SQL_Requests.MultyplyDeleteByID("movie_genre", idToDelete);
                    Database.TransactionExecute(query, new string[0, 2]);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveMovie();
            Close();
        }

        private void releaseDateTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Validation.Date(releaseDateTextBox);
        }

        private void durationTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Validation.Time(durationTextBox);
        }

        private void genreAddButton_Click(object sender, EventArgs e)
        {
            string[] genresAlreadyExist = new string[genresDataGridView.Rows.Count - hiddenRows.Count];

            int j = 0;
            for (int i = 0; i < genresDataGridView.Rows.Count; i++)
            {
                if (genresDataGridView.Rows[i].Visible)
                {
                    genresAlreadyExist[j] = genresDataGridView.Rows[i].Cells["genre_id"].Value?.ToString();
                    j++;
                }
            }
            GenreSelectForm genresDialogForm = new GenreSelectForm(genresAlreadyExist);
            genresDialogForm.ShowDialog();

            if (genresDialogForm.success)
            {
                for (int i = 0; i< genresDialogForm.answerLength; i++)
                {
                    if (hiddenRows.ContainsKey(genresDialogForm.selectedGenresID[i]))
                    {
                        DataGridViewRow row = hiddenRows[genresDialogForm.selectedGenresID[i]];
                        row.Visible = true;
                        hiddenRows.Remove(genresDialogForm.selectedGenresID[i]);
                    }
                    else
                    {
                        object[] newRow = new object[] {
                            "",
                            genresDialogForm.selectedGenresID[i],
                            genresDialogForm.selectedGenresTitle[i]
                        };

                        genresDataGridView.Rows.Add(newRow);
                    }
                    
                }
            }
        }

        private void genreDeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in genresDataGridView.SelectedRows)
            {
                if (!row.Visible)
                {
                    continue;
                }
                else if (row.Cells[0].Value?.ToString() == "")
                {
                    genresDataGridView.Rows.Remove(row);
                }
                else
                {
                    hiddenRows.Add(row.Cells[1].Value?.ToString(), row);
                    row.Visible = false;
                }
            }
        }

        private void releaseDateTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void durationTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MovieElementForm_Load(object sender, EventArgs e)
        {

        }

        private void titleTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
