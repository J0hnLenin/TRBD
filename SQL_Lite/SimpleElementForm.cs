﻿using Azure.Core;
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

namespace SQL_Lite
{
    public partial class SimpleElementForm : Form
    {
            
        public SimpleElementForm(string tableName)
        {
            InitializeComponent();
        }

        private void SimpleElementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
