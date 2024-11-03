using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Lite
{
    internal class Validation
    {
        public static bool Date(MaskedTextBox textBox)
        {
            DateTime DateFormated;

            if ((textBox.Text != "  .  .") && (!DateTime.TryParseExact(textBox.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateFormated)))
            {
                CustomMessageBoxForm messageForm = new CustomMessageBoxForm("        Неверно введена дата.\n" +
                                                                            "      Вводите дату в формате\n" +
                                                                            "              день.месяц.год");
                messageForm.ShowDialog();
                textBox.Text = "  .  .";
                return false;
            }
            return true;
        }
    }
}
