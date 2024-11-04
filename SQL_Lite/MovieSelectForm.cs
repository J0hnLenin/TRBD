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
    public partial class MovieSelectForm : Form
    {
        public string selectedMovieID = "-1";
        public string selectedMovieTitle = "";
        public string selectedDuration = "00:00";
        public bool success = false;

        public MovieSelectForm()
        {
            InitializeComponent();
            DataGridExtension.UpdateDataGridView(moviesDataGridView, SQL_Requests.SelectMovies(), new string[0, 2]);
            moviesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (moviesDataGridView.CurrentRow == null)
            {
                Close();
                return;
            }

            selectedMovieID = moviesDataGridView.CurrentRow.Cells[0].Value?.ToString();
            selectedMovieTitle = moviesDataGridView.CurrentRow.Cells[1].Value?.ToString();
            selectedDuration = moviesDataGridView.CurrentRow.Cells[4].Value?.ToString();
            success = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
