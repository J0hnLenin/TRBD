using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Lite
{
    public partial class GenreSelectForm : Form
    {
        public string[] selectedGenresID;
        public string[] selectedGenresTitle;
        public int answerLength = 0;
        public bool success = false;

        public GenreSelectForm(string[] alreadyExistingGenres)
        {
            InitializeComponent();
            DataGridExtension.UpdateDataGridView(genresDataGridView, SQL_Requests.SelectOrherGenres(alreadyExistingGenres), new string[0, 2]);
            genresDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            answerLength = genresDataGridView.SelectedRows.Count;
            if (answerLength == 0)
            {
                Close();
                return;
            }
            selectedGenresID = new string[answerLength];
            selectedGenresTitle = new string[answerLength];
            for(int i=0; i< answerLength; i++)
            {
                selectedGenresID[i] = genresDataGridView.SelectedRows[i].Cells[0].Value?.ToString();
                selectedGenresTitle[i] = genresDataGridView.SelectedRows[i].Cells[1].Value?.ToString();
            }
            success = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
