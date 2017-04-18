using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeiligWonenLoginUI
{
    public partial class VeiligWonenMainParrentUI : Form
    {

        public VeiligWonenMainParrentUI()
        {
            InitializeComponent();
            VeiligWonenUserMainUI UserUI = new VeiligWonenUserMainUI();
            UserUI.MdiParent = this;
            UserUI.Show();
        }

        private void Menu_LoginButton_Click(object sender, EventArgs e)
        {
            AdminLogin LoginAdmin = new AdminLogin();
            LoginAdmin.Show();
        }

        private void Exit_MenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
