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
    public partial class Parrent_MainUI : Form
    {
        
        public Parrent_MainUI(string role)
        {
            InitializeComponent();
            Name_Lable.Text = role;
        }

        private void Parrent_MainUI_Load(object sender, EventArgs e)
        {
            if (((Form)this).Controls["Name_Lable"].Text != "Admin")
            {
                AddHuis_MenuItem.Visible = false;
                AddData_MenuItem.Visible = false;
            }
        }

        private void ZoekHuis_MenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void Login_MenuItem_Click(object sender, EventArgs e)
        {
            LoginUI Login = new LoginUI();
            Login.MdiParent = this;
            Login.Show();
        }

        private void AddHuis_MenuItem_Click(object sender, EventArgs e)
        {
            Child_AddHuis Addhuis = new Child_AddHuis();
            Addhuis.MdiParent = this;
            Addhuis.Dock = DockStyle.Fill;
            Addhuis.Show();
        }

        private void Parrent_MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
