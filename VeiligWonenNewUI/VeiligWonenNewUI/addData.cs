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
            MySqlDataAdapter sda1 = new MySqlDataAdapter("Select WID From wijk where wijk.naam = '" + Wijk_dropdown.Text + "'", con);
            MySqlDataAdapter sda = new MySqlDataAdapter("Select CID From categoriecriminaliteit where categoriecriminaliteit.Soort= '" + Hcategorie_Combobox.Text + "'", con);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            sda1.Fill(dt);
            sda.Fill(dt1);

            string wijkstring = dt.Rows[0][0].ToString();
            int wijkint = int.Parse(wijkstring);
            LoadGridData("select * from subcategoriecriminaliteit where subcategoriecriminaliteit.WID = '" + wijkint + "' ");
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
            LoadGridData("select * From subcategoriecriminaliteit");
        }

        void RemoveComboItems()
        {
            SCategorie_Combobox.Items.Remove("Woninginbraak");
            SCategorie_Combobox.Items.Remove("Auto-inbraak");
            SCategorie_Combobox.Items.Remove("Geweldsdelicten");
            SCategorie_Combobox.Items.Remove("Bedreiging");
        }

        private void SCategorie_Combobox_DropDown(object sender, EventArgs e)
        {
            RemoveComboItems();
            if (Hcategorie_Combobox.Text == "Inbraak")
            {
                SCategorie_Combobox.Items.Add("Woninginbraak");
                SCategorie_Combobox.Items.Add("Auto-inbraak");
            }
            else if (Hcategorie_Combobox.Text == "Geweld")
            {
                SCategorie_Combobox.Items.Add("Geweldsdelicten");
                SCategorie_Combobox.Items.Add("Bedreiging");
            }
            else if (Hcategorie_Combobox.Text == "Vandalisme")
            {
                SCategorie_Combobox.Items.Add("Vernieling");
                SCategorie_Combobox.Items.Add("Bekladding");
            }
        }

        private void Hcategorie_Combobox_DropDown(object sender, EventArgs e)
        {
            SCategorie_Combobox.Text = "";
        }

        private void Button_Add_Click_1(object sender, EventArgs e)
        {
            if (Hcategorie_Combobox.Text != "" && SCategorie_Combobox.Text !="" && Perc2013.Text != "" && Perc2014.Text != "" && Perc2015.Text != "" && Perc2016.Text != "")
            {
                MySqlDataAdapter sda1 = new MySqlDataAdapter("Select WID From wijk where wijk.naam = '" + Wijk_dropdown.Text + "'", con);
                MySqlDataAdapter sda = new MySqlDataAdapter("Select CID From categoriecriminaliteit where categoriecriminaliteit.Soort= '" + Hcategorie_Combobox.Text + "'", con);
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                sda1.Fill(dt);
                sda.Fill(dt1);

                string wijkstring = dt.Rows[0][0].ToString();
                int wijkint = int.Parse(wijkstring);
                string hcategoriestring = dt1.Rows[0][0].ToString();
                int hcategorieint = int.Parse(hcategoriestring);

                con.Execute(@"INSERT INTO `sql11169883`.`subcategoriecriminaliteit`(`Naam`,`CID`,`WID`, `per2013`, `Per2014`,`Per2015`,`Per2016`) VALUES('" + SCategorie_Combobox.Text + "','" + hcategorieint + "','" + wijkint + "','" + Perc2013.Text + "','" + Perc2014.Text + "','" + Perc2015.Text + "','" + Perc2016.Text + "')", con);
            }
            else
            {
                MessageBox.Show("Please fill in all boxes");
            }

        }

        void ClearAll()
        {
            SCID_Text.Text = "";
            SCategorie_Combobox.SelectedIndex = -1;
            Hcategorie_Combobox.SelectedIndex = -1;
            Perc2013.Clear();
            Perc2014.Clear();
            Perc2015.Clear();
            Perc2016.Clear();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void LoadGridData(string query)
        {
            Addperc_Datagrid.Rows.Clear();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                int n = Addperc_Datagrid.Rows.Add();
                Addperc_Datagrid.Rows[n].Cells[0].Value = item["SCID"].ToString();
                Addperc_Datagrid.Rows[n].Cells[1].Value = item["WID"].ToString();
                Addperc_Datagrid.Rows[n].Cells[2].Value = item["CID"].ToString();
                Addperc_Datagrid.Rows[n].Cells[3].Value = item["Naam"].ToString();
                Addperc_Datagrid.Rows[n].Cells[4].Value = item["per2013"].ToString();
                Addperc_Datagrid.Rows[n].Cells[5].Value = item["Per2014"].ToString();
                Addperc_Datagrid.Rows[n].Cells[6].Value = item["Per2015"].ToString();
                Addperc_Datagrid.Rows[n].Cells[7].Value = item["Per2016"].ToString();
            }
        }


        private void Addperc_Datagrid_DoubleClick(object sender, EventArgs e)
        {
            if (Addperc_Datagrid.Rows.Count != 0)
            {
                SCID_Text.Text = Addperc_Datagrid.SelectedRows[0].Cells[0].Value.ToString();
                Wijk_dropdown.Text = Addperc_Datagrid.SelectedRows[0].Cells[1].Value.ToString();
                Hcategorie_Combobox.Text = Addperc_Datagrid.SelectedRows[0].Cells[2].Value.ToString();
                SCategorie_Combobox.Text = Addperc_Datagrid.SelectedRows[0].Cells[3].Value.ToString();
                Perc2013.Text = Addperc_Datagrid.SelectedRows[0].Cells[4].Value.ToString();
                Perc2014.Text = Addperc_Datagrid.SelectedRows[0].Cells[5].Value.ToString();
                Perc2015.Text = Addperc_Datagrid.SelectedRows[0].Cells[6].Value.ToString();
                Perc2016.Text = Addperc_Datagrid.SelectedRows[0].Cells[7].Value.ToString();

            }
            else
            {
                MessageBox.Show("Er is geen data om te weergeven");
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sda1 = new MySqlDataAdapter("Select WID From wijk where wijk.naam = '" + Wijk_dropdown.Text + "'", con);
      
            DataTable dt = new DataTable();
            sda1.Fill(dt);

            string wijkstring = dt.Rows[0][0].ToString();
            int wijkint = int.Parse(wijkstring);
         
            con.Execute("delete from subcategoriecriminaliteit where SCID = '" + SCID_Text.Text + "'");
            LoadGridData("select * from subcategoriecriminaliteit where subcategoriecriminaliteit.WID = '" + wijkint + "' ");

        }
    }
}
