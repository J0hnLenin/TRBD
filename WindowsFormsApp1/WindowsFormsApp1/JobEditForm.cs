using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class JobEditForm : Form
    {
        Int64 editId;
        private DataSet1 dataSet1;
        bool newJob;
        Int64 parrentId;

        public JobEditForm(DataSet1 dataSet1, bool newJob, Int64 parrentId, Int64 editId = 0)
        {
            InitializeComponent();
            this.editId = editId;
            this.dataSet1 = dataSet1;
            this.newJob = newJob;
            this.parrentId = parrentId;

            if (!newJob)
            {
                DataView dataView = dataSet1.Job.AsDataView();
                dataView.RowFilter = $"id = {editId}";

                if (dataView.Count > 0)
                {
                    DataRowView row = dataView[0]; // Получаем первую строку
                    start_date.Text = row["start_date"].ToString();
                    finish_date.Text = row["finish_date"].ToString();
                    description.Text = row["description"].ToString();
                }
            }
        }

        private void label_emploee_id_Click(object sender, EventArgs e)
        {

        }

        private void label_finish_date_Click(object sender, EventArgs e)
        {

        }

        private void label_start_date_Click(object sender, EventArgs e)
        {

        }

        private void label_description_Click(object sender, EventArgs e)
        {

        }

        private void start_date_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void JobEditForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveJob()
        {
            if (newJob)
            {
                DataRow newRow = dataSet1.Job.NewRow();

                if (start_date.Text != "  .  .")
                {
                    newRow["start_date"] = start_date.Text;
                }
                if (finish_date.Text != "  .  .")
                {
                    newRow["finish_date"] = finish_date.Text;
                }
                newRow["description"] = description.Text;
                newRow["employee_id"] = parrentId;
                dataSet1.Job.Rows.Add(newRow);

            }
            else
            {
                DataRow[] rows = dataSet1.Job.Select($"id = {editId}");

                if (rows.Length > 0)
                {
                    if (start_date.Text != "  .  .")
                    {
                        rows[0]["start_date"] = start_date.Text;
                    }
                    if (finish_date.Text != "  .  .")
                    {
                        rows[0]["finish_date"] = finish_date.Text;
                    }
                    rows[0]["description"] = description.Text;

                }
            }
        }

        private void JobEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveJob();
            dataSet1.Job.AcceptChanges();
        }

        private void start_date_Validating(object sender, CancelEventArgs e)
        {
            string DateValue;
            DateTime startDate;
            DateTime finishDate;

            DateValue = start_date.Text;
            if (DateValue != "  .  .")
            {
                if (!DateTime.TryParseExact(DateValue, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
                {
                    MessageBox.Show("Неверно введена дата. Вводите дату в формате день.месяц.год");
                    e.Cancel = true;
                }

                if (finish_date.Text != "  .  .")
                {
                    if (DateTime.TryParse(finish_date.Text, out finishDate))
                    {
                        if (finishDate < startDate)
                        {
                            MessageBox.Show("Неверно введена дата. Дата начала не может быть раньше даты окончания");
                            e.Cancel = true;
                        }
                    }
                }

            }
        }

        private void finish_date_Validating(object sender, CancelEventArgs e)
        {
            string DateValue;
            DateTime DateFormated;

            DateValue = finish_date.Text;
            if (DateValue != "  .  .")
            {
                if (!DateTime.TryParseExact(DateValue, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateFormated))
                {
                    MessageBox.Show("Неверно введена дата. Вводите дату в формате день.месяц.год");
                    e.Cancel = true;
                }
            }
        }
    }
}
