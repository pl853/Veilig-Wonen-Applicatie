using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace VeiligWonenNewUI
{
    public partial class Login_UI : Form
    {
        MySqlConnection con = new MySqlConnection("server = sql11.freemysqlhosting.net; database=sql11168746; user=sql11168746; password=7u21Rl2GCK");

        MySqlDataAdapter sda;

        DataTable dt;

        int loginCount = 3;



        public Login_UI()
        {
            InitializeComponent();
        }

        private void Password_TextBox_Enter(object sender, EventArgs e)
        {
            Password_TextBox.Text = "";
            Password_TextBox.isPassword = true;
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            sda = new MySqlDataAdapter(@"SELECT Role, UserName FROM login Where UserName = '" + Username_TextBox.Text + 
            "' and Password = '" + Password_TextBox.Text+ "'", con);
            dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Main_Ui MainUI = new Main_Ui(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString());
                MainUI.Show();
            }
            else
            {
                loginCount -= 1;

                MessageBox.Show("Incorrect Username or Password \n you have " + loginCount + " attempts left.");

                if (loginCount <= 0)
                {
                    Application.Exit();
                }
            }

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
