﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flood_it
{
    public partial class RuleBox : Form
    {
        public RuleBox()
        {
            InitializeComponent();
        }

        private void RuleBox_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void OkButRule_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
