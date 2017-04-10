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
using Dapper;


namespace VeiligWonenLoginUI
{
    public partial class Child_AddHuis : Form
    {
        
        public Child_AddHuis()
        {
            InitializeComponent();
        }

        private void Child_AddHuis_Load(object sender, EventArgs e)
        {
            string query = "SELECT [StadsGebied].[GID] , [StadsGebied].[Naam] from [StadsGebied]";  //Aanmaken van invulling voor Combobox
            fillcombo(Gebied_Dropdown, query, "Naam", "GID");            //Aanmaken van invulling voor Combobox
            Gebied_Dropdown_SelectedIndexChanged(null, null);            //Aanmaken van invulling voor Combobox
            LoadGridData(@"select * From Huis where Huis.StadsGebied = '" + Gebied_Dropdown.Text + "' and Huis.Wijk = '" + Wijk_Dropdown.Text + "'");

        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBConnector.ConnectionValue("VeiligWonenDataBase")))
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"Declare @MaxNo int,@No Varchar(50); Select @MaxNo = ISNULL (Max(cast(Right(HID,5) as Int)),0)+1 From Huis; Select 'HID' + Right ('00000' + Cast(@MaxNo AS varchar),5);", connection.ConnectionString);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                HID_Textbox.Text = dt.Rows[0][0].ToString();
                connection.Execute(@"INSERT INTO [Huis] ([HID],[StadsGebied],[Wijk],[Straat],[HuisNummer],[KoopHuur],[Prijs],[Omschrijving])VALUES ('"+HID_Textbox.Text+"','" + Gebied_Dropdown.Text + "','" + Wijk_Dropdown.Text + "','" + Straat_TextBox.Text + "','" +Huisnum_Textbox.Text + "','" + HuurKoop_Textbox.Text+ "','" + Prijs_Textbox.Text + "','" + Omschrijving_TextBox.Text+"')", connection.ConnectionString);
            }
            LoadGridData(@"select * From Huis where Huis.StadsGebied = '" + Gebied_Dropdown.Text + "' and Huis.Wijk = '" + Wijk_Dropdown.Text + "'");


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBConnector.ConnectionValue("VeiligWonenDataBase")))
            {
                connection.Execute(@"Update Huis Set HID = '" + HID_Textbox.Text + "',StadsGebied = '" + Gebied_Dropdown.Text + "',Wijk ='" + Wijk_Dropdown.Text + "',Straat = '" + Straat_TextBox.Text + "',HuisNummer = '" + Huisnum_Textbox.Text + "',KoopHuur ='" + HuurKoop_Textbox.Text + "',Prijs = '" + Prijs_Textbox.Text + "',Omschrijving = '" + Omschrijving_TextBox.Text + "' where HID = '" + HID_Textbox.Text + "'", connection.ConnectionString);
                LoadGridData(@"select * From Huis where Huis.StadsGebied = '" + Gebied_Dropdown.Text + "' and Huis.Wijk = '" + Wijk_Dropdown.Text + "'");
                MessageBox.Show("Succesfully Updated");
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            LoadGridData(@"select * From Huis where Huis.StadsGebied = '" + Gebied_Dropdown.Text + "' " +
                "and Huis.Wijk = '" + Wijk_Dropdown.Text + "'" +
                "and Huis.HuisNummer = '" + Huisnum_Textbox.Text + "'" +
                "or Huis.Straat = '" + Straat_TextBox.Text + "'" +
                "or Huis.Prijs = '" + Prijs_Textbox.Text + "'");
        }

        private void Gebied_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_HuisResults.Rows.Clear(); // DataGrid leeg maken
            int val;
            Int32.TryParse(Gebied_Dropdown.SelectedValue.ToString(), out val);
            string query = "SELECT [WID] , [Naam],[GID] from [Wijk] WHERE [GID] = "+val;
            fillcombo(Wijk_Dropdown, query, "Naam", "WID");
        }

        private void Wijk_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridData(@"select * From Huis where Huis.StadsGebied = '" + Gebied_Dropdown.Text + "' and Huis.Wijk = '" + Wijk_Dropdown.Text + "'");
        }

        public void fillcombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBConnector.ConnectionValue("VeiligWonenDataBase")))
            {
                DataTable Table = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(query, connection.ConnectionString);
                sda.Fill(Table);
                combo.DataSource = Table;
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
            }

        }

        public void LoadGridData(string query)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBConnector.ConnectionValue("VeiligWonenDataBase")))
            {
                dataGridView_HuisResults.Rows.Clear();
                SqlDataAdapter sda = new SqlDataAdapter(query, connection.ConnectionString);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView_HuisResults.Rows.Add();
                    dataGridView_HuisResults.Rows[n].Cells[0].Value = item["HID"].ToString();
                    dataGridView_HuisResults.Rows[n].Cells[1].Value = item["StadsGebied"].ToString();
                    dataGridView_HuisResults.Rows[n].Cells[2].Value = item["Wijk"].ToString();
                    dataGridView_HuisResults.Rows[n].Cells[3].Value = item["Straat"].ToString();
                    dataGridView_HuisResults.Rows[n].Cells[4].Value = item["HuisNummer"].ToString();
                    dataGridView_HuisResults.Rows[n].Cells[5].Value = item["KoopHuur"].ToString();
                    dataGridView_HuisResults.Rows[n].Cells[6].Value = item["Prijs"].ToString();
                    dataGridView_HuisResults.Rows[n].Cells[7].Value = item["Omschrijving"].ToString();
                }

            }

        }

        private void dataGridView_HuisResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HID_Textbox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[0].Value.ToString();
            Gebied_Dropdown.SelectedItem = dataGridView_HuisResults.SelectedRows[0].Cells[1].Value.ToString();
            Wijk_Dropdown.SelectedItem = dataGridView_HuisResults.SelectedRows[0].Cells[2].Value.ToString();
            Straat_TextBox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[3].Value.ToString();
            Huisnum_Textbox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[4].Value.ToString();
            HuurKoop_Textbox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[5].Value.ToString();
            Prijs_Textbox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[6].Value.ToString();
            Omschrijving_TextBox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBConnector.ConnectionValue("VeiligWonenDataBase")))
            {
                connection.Execute(@"Delete  from huis where HID='" + HID_Textbox.Text + "'", connection.ConnectionString);
            }
            LoadGridData(@"select * From Huis where Huis.StadsGebied = '" + Gebied_Dropdown.Text + "' and Huis.Wijk = '" + Wijk_Dropdown.Text + "'");
        }

    }
}
