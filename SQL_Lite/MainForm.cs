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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void objectStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mainMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void OpenMDIChildren(ToolStripItemClickedEventArgs e)
        {
            bool alreadyExists = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == e.ClickedItem.Text)
                {
                    this.MdiChildren[i].Activate();
                    alreadyExists = true;
                    break;
                }
            }
            if (!alreadyExists)
            {
                ChildForm newMDIChild = new ChildForm(e);
                newMDIChild.MdiParent = this;
                newMDIChild.Show();
            }
        }
        private void objectStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenMDIChildren(e);
        }
        private void referenceTableStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenMDIChildren(e);
        }

        private void referenceTableStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void movieMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
