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
    public partial class addData : Form
    {
        MySqlConnection con = new MySqlConnection("server = sql11.freemysqlhosting.net; database=sql11169883; user=sql11169883; password=sbCqYkpscM");
        public addData()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {

        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sda1 = new MySqlDataAdapter("Select WID where wijk = '" + Wijk_dropdown.Text + "'", con);
            MySqlDataAdapter sda = new MySqlDataAdapter("Select SCID where wijk = '" + Hcategorie_Combobox.Text + "'", con);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            sda1.Fill(dt);
            sda.Fill(dt1);

            string wijkstring = dt.Rows[0][0].ToString();
            int wijkint = int.Parse(wijkstring);
            string hcategoriestring = dt1.Rows[0][1].ToString();
            int hcategorieint = int.Parse(hcategoriestring);

            con.Execute(@"INSERT INTO `sql11169883`.`subcategoriecriminaliteit`
            (`SCID`,
            `Naam`,
            `CID`,
            `WID`,
            `per2013`,
            `Per2014`,
            `Per2015`,
            `Per2016`)
            VALUES
            (,
            ,
            ,
            ,
            ,
            ,
            ,
            )
            ");

        }

        private void gebied_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(gebied_Dropdown.SelectedValue.ToString(), out val);
            string query = "SELECT WID , Naam,GID from wijk WHERE GID = " + val;
            fillcombo(Wijk_dropdown, query, "Naam", "WID");
        }

        private void gebied_Dropdown_MouseDown(object sender, MouseEventArgs e)
        {
            string query = "SELECT stadsgebied.GID , stadsgebied.Naam from stadsgebied";  //Aanmaken van invulling voor Combobox
            fillcombo(gebied_Dropdown, query, "Naam", "GID");            //Aanmaken van invulling voor Combobox
            gebied_Dropdown_SelectedIndexChanged(null, null);            //Aanmaken van invulling voor Combobox
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

        private void addData_Load(object sender, EventArgs e)
        {
            string query = "SELECT stadsgebied.GID , stadsgebied.Naam from stadsgebied";  //Aanmaken van invulling voor Combobox
            fillcombo(gebied_Dropdown, query, "Naam", "GID");            //Aanmaken van invulling voor Combobox
            gebied_Dropdown_SelectedIndexChanged(null, null);            //Aanmaken van invulling voor Combobox
        }


        private void SCategorie_Combobox_MouseHover(object sender, EventArgs e)
        {
            if (Hcategorie_Combobox.Text == "Inbraak")
            {
                SCategorie_Combobox.Items.Add("Woninginbraak");
                SCategorie_Combobox.Items.Add("auto-inbraak");
            }
        }

        private void SCategorie_Combobox_MouseClick(object sender, MouseEventArgs e)
        {
            RemoveComboItems();
            if (Hcategorie_Combobox.Text == "Inbraak")
            {
                SCategorie_Combobox.Items.Add("Woninginbraak");
                SCategorie_Combobox.Items.Add("auto-inbraak");
            }
        }
        
        void RemoveComboItems()
        {
            SCategorie_Combobox.Items.Remove("Woninginbraak");
            SCategorie_Combobox.Items.Remove("Auto-inbraak");
        }
    }
}
