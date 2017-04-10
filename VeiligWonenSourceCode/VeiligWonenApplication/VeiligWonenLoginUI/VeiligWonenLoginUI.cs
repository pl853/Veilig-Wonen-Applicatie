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
    public partial class LoginUI : Form
    {
        public int AttemptCount = 3;

        public LoginUI()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBConnector.ConnectionValue("VeiligWonenDataBase")))
            {
                DataTable dt = new System.Data.DataTable();

                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT Role FROM [LoginAdmin] Where UserName = '" + UserNameText.Text + 
                    "' and Password = '" + PasswordText.Text + "'", connection.ConnectionString);

                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Parrent_MainUI MainUI = new Parrent_MainUI(dt.Rows[0][0].ToString());
                    this.Hide();
                    MainUI.Show();
                    
                }
                else
                {
                    AttemptCount -= 1;
                    IncorrectLabel.Text = "Invalid User Name or Password You have " + AttemptCount +" attempts left";

                    MessageBox.Show("Invalid Username or Password. You have " + AttemptCount + " attempts Left.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } 
                if (AttemptCount == 0)
                {
                    Application.Exit();
                }


        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }
    }
}
