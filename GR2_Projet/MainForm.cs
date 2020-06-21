using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void ChangePanel(UserControl tab)
        {
            ClearPanelRessources();
            ClearPanel();
            tab.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(tab);
        }

        public void ClearPanel()
        {
            mainPanel.Controls.Clear();
        }

        public void ClearPanelRessources()
        {
            foreach(Control ctrl in mainPanel.Controls)
            {
                ctrl.Dispose();
            }
        }
    }
}
