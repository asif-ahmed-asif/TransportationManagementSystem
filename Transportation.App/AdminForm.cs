﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportation.App
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            schedule1.BringToFront();

            adminHome1.BringToFront();
        }

        private void adminBtnHome_Click(object sender, EventArgs e)
        {
            //adminHome1.Height = adminBtnHome.Height;
            this.pnlRed.Height = this.adminBtnHome.Height;
            this.pnlRed.Top = this.adminBtnHome.Top;
            adminHome1.BringToFront();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            //schedule1.Height = btnSchedule.Height;
            this.pnlRed.Height = this.btnSchedule.Height;
            this.pnlRed.Top = this.btnSchedule.Top;
            schedule1.BringToFront();
        }

        private void schedule1_Load(object sender, EventArgs e)
        {

        }
    }
}
