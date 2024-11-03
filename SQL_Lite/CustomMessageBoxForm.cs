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
    public partial class CustomMessageBoxForm : Form
    {
        public CustomMessageBoxForm(string message)
        {
            InitializeComponent();
            label.Text = message;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
