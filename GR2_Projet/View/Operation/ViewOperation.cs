﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet.View.Operation
{
    public partial class ViewOperation : BaseView
    {
        public ViewOperation()
        {
            InitializeComponent();
        }

        private void returnPreviousViewBtn_Click(object sender, EventArgs e)
        {
            ViewManager.Instance.ShowViewAccount();
        }
    }
}
