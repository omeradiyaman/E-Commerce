﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret
{
    public partial class LoadingForm : DevExpress.XtraEditors.XtraForm
    {
        public LoadingForm()
        {
            InitializeComponent();

            timer.Interval = 3000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }
    }
}