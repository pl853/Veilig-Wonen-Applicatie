﻿using System;
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
    public partial class Addhuis_UI : Form
    {
        MySqlConnection con = new MySqlConnection("server = sql11.freemysqlhosting.net; database=sql11169883; user=sql11169883; password=sbCqYkpscM");


        public Addhuis_UI()
        {
            InitializeComponent();
        }

        private void Addhuis_UI_Load(object sender, EventArgs e)
        {
            LoadGridData("select * from huis");

            string query = "SELECT stadsgebied.GID , stadsgebied.Naam from stadsgebied";  //Aanmaken van invulling voor Combobox
            fillcombo(gebied_Dropdown, query, "Naam", "GID");            //Aanmaken van invulling voor Combobox
            Gebied_Dropdown_SelectedIndexChanged(null, null);            //Aanmaken van invulling voor Combobox

        }
        public void LoadGridData(string query)
        {
            dataGridView_HuisResults.Rows.Clear();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
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
                dataGridView_HuisResults.Rows[n].Cells[8].Value = item["Lat"].ToString();
                dataGridView_HuisResults.Rows[n].Cells[9].Value = item["Long"].ToString();
            }
        }

        private void dataGridView_HuisResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_HuisResults.Rows.Count != 0)
            {
                HID_Textbox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[0].Value.ToString();
                gebied_Dropdown.Text = dataGridView_HuisResults.SelectedRows[0].Cells[1].Value.ToString();
                Wijk_Dropdown.Text = dataGridView_HuisResults.SelectedRows[0].Cells[2].Value.ToString();
                Straat_TextBox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[3].Value.ToString();
                Huisnum_Textbox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[4].Value.ToString();
                HuurKoop_Textbox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[5].Value.ToString();
                Prijs_Textbox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[6].Value.ToString();
                Omschrijving_TextBox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[7].Value.ToString();
                LatTextBox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[8].Value.ToString();
                LongTextBox.Text = dataGridView_HuisResults.SelectedRows[0].Cells[9].Value.ToString();
            }
            else
            {
                MessageBox.Show("Er is geen data om te weergeven");
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if(HID_Textbox.Text != "")
            {
                con.Execute(@"Delete  from huis where HID='" + HID_Textbox.Text + "'", con.ConnectionString);
                LoadGridData(@"select * From huis ");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please select a item from the datagrid by double clicking on the item.");
            }

        }

        private void Gebied_Dropdown_MouseDown(object sender, MouseEventArgs e)
        {

            string query = "SELECT stadsgebied.GID , stadsgebied.Naam from stadsgebied";  //Aanmaken van invulling voor Combobox
            fillcombo(gebied_Dropdown, query, "Naam", "GID");            //Aanmaken van invulling voor Combobox
            Gebied_Dropdown_SelectedIndexChanged(null, null);            //Aanmaken van invulling voor Combobox

        }
        public void fillcombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            sda.Fill(dt);
            combo.DataSource = dt;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;

        }

        private void Gebied_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(gebied_Dropdown.SelectedValue.ToString(), out val);
            string query = "SELECT WID , Naam,GID from wijk WHERE GID = " + val;
            fillcombo(Wijk_Dropdown, query, "Naam", "WID");
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            LoadGridData(@"SELECT * FROM huis where stadsgebied = '" + gebied_Dropdown.Text + "' and wijk = '" + Wijk_Dropdown.Text + "'");

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        void ClearAll()
        {
            HID_Textbox.Clear();
            Straat_TextBox.Clear();
            Huisnum_Textbox.Clear();
            Prijs_Textbox.Clear();
            LatTextBox.Clear();
            LongTextBox.Clear();
            Omschrijving_TextBox.Clear();
            HuurKoop_Textbox.SelectedIndex = -1;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if(gebied_Dropdown.Text!=""&& Wijk_Dropdown.Text != "" && Straat_TextBox.Text != "" && Huisnum_Textbox.Text != "" && Prijs_Textbox.Text != "" && LatTextBox.Text != "" && LongTextBox.Text != "")
            {
                con.Execute(@"INSERT INTO `sql11169883`.`huis`(`StadsGebied`,`Wijk`,`Straat`,`Huisnummer`,`KoopHuur`,`Prijs`,`Omschrijving`,`Lat`,`Long`) VALUES('" + gebied_Dropdown.Text + "','" + Wijk_Dropdown.Text + "','" + Straat_TextBox.Text + "','" + Huisnum_Textbox.Text + "','" + HuurKoop_Textbox.Text + "','" + Prijs_Textbox.Text + "','" + Omschrijving_TextBox.Text + "','" + LatTextBox.Text + "','" + LongTextBox.Text + "')", con);
                LoadGridData(@"select * From huis where huis.StadsGebied = '" + gebied_Dropdown.Text + "' and huis.Wijk = '" + Wijk_Dropdown.Text + "'");

            }
            else
            {
                MessageBox.Show("please fill in all required forms");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (gebied_Dropdown.Text != "" && Wijk_Dropdown.Text != "" && Straat_TextBox.Text != "" && Huisnum_Textbox.Text != "" && Prijs_Textbox.Text != "" && LatTextBox.Text != "" && LongTextBox.Text != "")
            {
                con.Execute("UPDATE sql11169883.huis SET huis.StadsGebied = '" + gebied_Dropdown.Text + "' " + " ,huis.Wijk = '" + Wijk_Dropdown.Text + "' ,Straat='" + Straat_TextBox.Text + "' , Huisnummer = '" + Huisnum_Textbox.Text + "' ,KoopHuur = '" + HuurKoop_Textbox.Text + "' , Prijs = '" + Prijs_Textbox.Text + "' , Omschrijving = '" + Omschrijving_TextBox.Text + "' , huis.Lat = '" + LatTextBox.Text + "'  , huis.Long = '" + LongTextBox.Text + "' WHERE HID ='" + HID_Textbox.Text + "'", con);
                MessageBox.Show("Succesfully Updated");
                LoadGridData(@"select * From huis where huis.StadsGebied = '" + gebied_Dropdown.Text + "' " + "and huis.Wijk = '" + Wijk_Dropdown.Text + "'");
            }

            else
            {
                MessageBox.Show("please fill in all required forms");
            }
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            LoadGridData(@"select * From huis ");
        }
    }
}
