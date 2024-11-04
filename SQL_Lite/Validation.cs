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
        public static bool Time(MaskedTextBox textBox)
        {
            DateTime DateFormated;

            if ((textBox.Text != "  :") && (!DateTime.TryParseExact(textBox.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateFormated)))
            {
                CustomMessageBoxForm messageForm = new CustomMessageBoxForm("        Неверно введено время.\n" +
                                                                            "      Вводите время в формате\n" +
                                                                            "                 часы:минуты");
                messageForm.ShowDialog();
                textBox.Text = "  :";
                return false;
            }
            return true;
        }

        public static string changeDateFormat(string inputDate)
        {
            // from dd.mm.yyyy to yyyy-mm-dd
            string formattedDate = "0000-00-00";
            if (inputDate != "  .  .")
            {
                DateTime date = DateTime.ParseExact(inputDate, "dd.MM.yyyy", null);
                formattedDate = date.ToString("yyyy-MM-dd");
            }
            return formattedDate;
        }
        public static string changeTimeFormat(string inputTime)
        {
            // from hh:mm to hh:mm:ss
            string formattedTime = "00:00:00";
            if (inputTime != "  :")
            {
                formattedTime = string.Format("{0}:00", inputTime);
            }
            return formattedTime;
        }
        public static string addTime(string time1, string time2)
        {
            // hh:mm + hh:mm 
            if (time1 == "  :") time1 = "00:00";
            if (time2 == "  :") time2 = "00:00";
            TimeSpan ts1 = TimeSpan.Parse(time1);
            TimeSpan ts2 = TimeSpan.Parse(time2);

            TimeSpan sum = ts1 + ts2;
            return string.Format("{0:D2}:{1:D2}", ((int)sum.TotalHours)%24, sum.Minutes);
        }
        public static bool CheckFill(string label, string text)
        {
            if (text == "" || text == "-1")
            {
                CustomMessageBoxForm messageForm = new CustomMessageBoxForm(string.Format("\n                Поле '{0}'\n" + 
                                                                                          "       должно быть заполнено", label));
                messageForm.ShowDialog();
                return false;
            }
            return true;
        }

        public static bool CheckInt(string text)
        {
            int val = 0;
            System.Int32.TryParse(text, out val);
            if (val <= 0)
            {
                CustomMessageBoxForm messageForm = new CustomMessageBoxForm("     Введите натурально число");
                messageForm.ShowDialog();
                return false;
            }
            return true;
        }
    }
}
