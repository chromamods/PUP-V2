﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUP_V2
{
    public partial class Emergency : Form
    {
        public Emergency()
        {
            InitializeComponent();
        }

        private void buttonEmergencyBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
