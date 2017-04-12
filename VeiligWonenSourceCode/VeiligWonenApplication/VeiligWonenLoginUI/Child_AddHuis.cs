using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
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
        MySqlConnection con = new MySqlConnection("server = sql11.freemysqlhosting.net; database=sql11168746; user=sql11168746; password=7u21Rl2GCK");

        public Child_AddHuis()
        {
            InitializeComponent();
        }

        private void Child_AddHuis_Load(object sender, EventArgs e)
        {

            LoadGridData("select * from huis");
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            con.Execute(@"INSERT INTO `sql11168746`.`huis`(`StadsGebied`,`Wijk`,`Straat`,`Huisnummer`,`KoopHuur`,`Prijs`,`Omschrijving`,`Lat`,`Long`) VALUES('" + Gebied_Dropdown.Text + "','" + Wijk_Dropdown.Text + "','" + Straat_TextBox.Text + "','" + Huisnum_Textbox.Text + "','" + HuurKoop_Textbox.Text + "','" + Prijs_Textbox.Text + "','" + Omschrijving_TextBox.Text + "','" + LatTextBox.Text + "','" + LongTextBox.Text + "')", con);
            LoadGridData(@"select * From huis where huis.StadsGebied = '" + Gebied_Dropdown.Text + "' and huis.Wijk = '" + Wijk_Dropdown.Text + "'");

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            con.Execute(@"Update huis Set HID = '" + HID_Textbox.Text + "',StadsGebied = '" + Gebied_Dropdown.Text + "',Wijk ='" + Wijk_Dropdown.Text + "',Straat = '" + Straat_TextBox.Text + "',HuisNummer = '" + Huisnum_Textbox.Text + "',KoopHuur ='" + HuurKoop_Textbox.Text + "',Prijs = '" + Prijs_Textbox.Text + "',Omschrijving = '" + Omschrijving_TextBox.Text + "', Lat = '" + LatTextBox.Text + "',Long = '" + LongTextBox.Text + "' where HID = '" + HID_Textbox.Text + "'", con);
            MessageBox.Show("Succesfully Updated");
            LoadGridData(@"select * From huis where huis.StadsGebied = '" + Gebied_Dropdown.Text + "' " + "and huis.Wijk = '" + Wijk_Dropdown.Text + "'");
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (Straat_TextBox.Text != "" && Huisnum_Textbox.Text != "")
            {
                LoadGridData(@"SELECT `huis`.`HID`,
                            `huis`.`StadsGebied`,
                            `huis`.`Wijk`,
                            `huis`.`Straat`,
                            `huis`.`Huisnummer`,
                            `huis`.`KoopHuur`,
                            `huis`.`Prijs`,
                            `huis`.`Omschrijving`
                             FROM `sql11168746`.`huis`
                             where huis.Straat = '" + Straat_TextBox.Text + "' and huis.Huisnummer = '" + Huisnum_Textbox.Text + "'");
            }
            else
            {
                LoadGridData(@"select * From huis where huis.StadsGebied = '" + Gebied_Dropdown.Text + "' " + "and huis.Wijk = '" + Wijk_Dropdown.Text + "'");
            }
        }

        private void Gebied_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(Gebied_Dropdown.SelectedValue.ToString(), out val);
            string query = "SELECT WID , Naam,GID from wijk WHERE GID = " + val;
            fillcombo(Wijk_Dropdown, query, "Naam", "WID");
        }

        private void Wijk_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            }
        }

        private void dataGridView_HuisResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_HuisResults.Rows.Count != 0)
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
            else
            {
                MessageBox.Show("Er is geen data om te weergeven");
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            con.Execute(@"Delete  from huis where HID='" + HID_Textbox.Text + "'", con.ConnectionString);

            LoadGridData(@"select * From huis where huis.StadsGebied = '" + Gebied_Dropdown.Text + "' and huis.Wijk = '" + Wijk_Dropdown.Text + "'");
        }

        private void Gebied_Dropdown_MouseDown(object sender, MouseEventArgs e)
        {
            string query = "SELECT stadsgebied.GID , stadsgebied.Naam from stadsgebied";  //Aanmaken van invulling voor Combobox
            fillcombo(Gebied_Dropdown, query, "Naam", "GID");            //Aanmaken van invulling voor Combobox
            Gebied_Dropdown_SelectedIndexChanged(null, null);            //Aanmaken van invulling voor Combobox
        }
    }
}
