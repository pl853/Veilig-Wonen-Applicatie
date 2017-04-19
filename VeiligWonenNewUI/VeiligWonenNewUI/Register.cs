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
using Dapper;

namespace VeiligWonenNewUI
{
    public partial class Register : Form
    {
        MySqlConnection con = new MySqlConnection("server = sql11.freemysqlhosting.net; database=sql11169883; user=sql11169883; password=sbCqYkpscM");

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            string role = "User";
            if (passcheck_text.Text != Password_text.Text)
            {
                MessageBox.Show("De wachtwoorden komen niet overeen.");
            }
            else if (passcheck_text.Text == "" && username_text.Text == "" && firstname_text.Text == "" && lastname_text.Text == "" && email_text.Text == "" && Password_text.Text == "")
            {
                MessageBox.Show("Je moet alles invullen om door te gaan.");
            }
            else
            {
                con.Execute(@"INSERT INTO `sql11169883`.`login`
                (`UserName`,
                `Password`,
                `Role`,
                `Email`,
                `Firstname`,
                `Lastname`)
                VALUES('"+username_text.Text+ "','"+Password_text.Text+"','" + role+ "','"+email_text.Text+ "','"+firstname_text.Text+ "','"+lastname_text.Text+"')", con);
                MessageBox.Show("Gelukt! U kunt nu inloggen");
            }
            Login_UI login = new Login_UI();
            this.Hide();
            login.Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {       
            Application.Exit();
        }

        private void Password_text_Enter(object sender, EventArgs e)
        {
            Password_text.Text = "";
            Password_text.isPassword = true;
        }

        private void passcheck_text_Enter(object sender, EventArgs e)
        {
            passcheck_text.Text = "";
            passcheck_text.isPassword = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_UI login = new Login_UI();
            login.Show();
        }
    }
}
