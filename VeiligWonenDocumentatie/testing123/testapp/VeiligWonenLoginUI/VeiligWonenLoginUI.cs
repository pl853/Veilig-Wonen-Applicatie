using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VeiligWonenLoginUI
{
    public partial class AdminLogin : Form
    {
        public int AttemptCount = 3; 
        
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserNameText.Clear();
            PasswordText.Clear();
            UserNameText.Focus();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBConnector.ConnectionValue("VeiligWonenDB")))
            {
                DataTable dt = new DataTable();

                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *FROM [Login] Where UserName = '" + UserNameText.Text + 
                    "' and Password = '" + PasswordText.Text + "'", connection.ConnectionString);

                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    VeiligWonenUserMainUI UserUI = new VeiligWonenUserMainUI();
                    UserUI.Hide();
                }
                else
                {
                    AttemptCount -= 1;
                    //IncorrectLabel.Text = "Invalid User Name or Password You have {0} attempts left";

                    MessageBox.Show("Invalid Username or Password. You have " + AttemptCount + " attempts Left.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearButton_Click(sender, e);
                }

            } 
                if (AttemptCount == 0)
                {
                    Application.Exit();
                }


        }
    }
}
