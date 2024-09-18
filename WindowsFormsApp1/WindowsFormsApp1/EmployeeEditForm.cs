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

namespace WindowsFormsApp1
{
    public partial class EmployeeEditForm : Form
    {
        Int64 editId;
        private DataSet1 dataSet1;

        public EmployeeEditForm(DataSet1 dataSet1, bool newEmployee, Int64 editId=0)
        {
            InitializeComponent();
            this.editId = editId;
            this.dataSet1 = dataSet1;
            id.Text = editId.ToString();

            if (!newEmployee)
            {
                DataView dataView = dataSet1.Employee.AsDataView();
                dataView.RowFilter = $"id = {editId}";

                if (dataView.Count > 0)
                {
                    DataRowView row = dataView[0]; // Получаем первую строку
                    name.Text = row["name"].ToString();
                    birthday.Text = row["birthday"].ToString();
                    inn.Text = row["inn"].ToString();
                    snils.Text = row["snils"].ToString();
                    passport_series.Text = row["passport_series"].ToString();
                    passport_number.Text = row["passport_number"].ToString();
                }
            }
            

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void name_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void id_label_Click(object sender, EventArgs e)
        {

        }

        private void inn_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void birthday_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void passport_series_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void birthday_Validating(object sender, CancelEventArgs e)
        {
            string DateValue;
            DateTime DateFormated;

            DateValue = birthday.Text;
            if (!DateTime.TryParseExact(DateValue, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateFormated))
            {
                MessageBox.Show("Неверно введена дата. Вводите дату в формате день.месяц.год");
                e.Cancel = true;
            }
        }
    }
}
