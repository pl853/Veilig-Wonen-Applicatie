using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace VeiligWonenNewUI
{
    public partial class Main_Ui : Form
    {
        MySqlConnection con = new MySqlConnection("server = sql11.freemysqlhosting.net; database=sql11169883; user=sql11169883; password=sbCqYkpscM");

        MySqlDataAdapter sda;

        DataTable dt;

        GMarkerGoogle marker;

        GMapOverlay markerOverlay;

        List<string> huizen = new List<string>();

        Addhuis_UI Addhuis = new Addhuis_UI();

        addData AddData = new addData();


        public Main_Ui(string Role, string UserName)
        {
            InitializeComponent();

            //filling labels

            Name_Label.Text = UserName;
            Role_label.Text = Role;
        }

        private void VeiligWonen_Load(object sender, EventArgs e)
        {
            OnAppLoad();

        }

        void OnAppLoad()
        {
            // fill chart

            Inbraak_Chart.Series["Perc"].Points.AddXY("2013", 12);
            Inbraak_Chart.Series["Perc"].Points.AddXY("2014", 12.1);
            Inbraak_Chart.Series["Perc"].Points.AddXY("2015", 11.1);
            Inbraak_Chart.Series["Perc"].Points.AddXY("2016", 13.5);

            gewelds_chart.Series["Perc"].Points.AddXY("2013", 4);
            gewelds_chart.Series["Perc"].Points.AddXY("2014", 3.5);
            gewelds_chart.Series["Perc"].Points.AddXY("2015", 4.6);
            gewelds_chart.Series["Perc"].Points.AddXY("2016", 5.5);

            vandilsme_chart.Series["Perc"].Points.AddXY("2013", 14.9);
            vandilsme_chart.Series["Perc"].Points.AddXY("2014", 18.7);
            vandilsme_chart.Series["Perc"].Points.AddXY("2015", 17);
            vandilsme_chart.Series["Perc"].Points.AddXY("2016", 13.9);

            // what check who logged and what to display
            if (Role_label.Text != "Admin")
            {
                ManageData_MenuItem.Visible = false;
                Managehuizen_MenuItem.Visible = false;
            }
            // load google maps att
            ShowMarkers("select * from huis ", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` ");
            GoogleMapsControl.DragButton = MouseButtons.Left;
            GoogleMapsControl.CanDragMap = true;
            GoogleMapsControl.MapProvider = GMapProviders.GoogleMap;
            GoogleMapsControl.Position = new PointLatLng(51.906582, 4.492979);
            GoogleMapsControl.MinZoom = 11;
            GoogleMapsControl.MaxZoom = 24;
            GoogleMapsControl.Zoom = 12;
        }

        void CreateMarker(string name, double Latitude, double Longditute, string Huisnummer, string Prijs, string KoopHuur)
        {
            markerOverlay = new GMapOverlay("marker");
            marker = new GMarkerGoogle(new PointLatLng(Latitude, Longditute), GMarkerGoogleType.blue_pushpin);
            markerOverlay.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("\n" + name + " {0}\n{1} \nPrijs: €{2},-", Huisnummer, KoopHuur, Prijs);
            GoogleMapsControl.Overlays.Add(markerOverlay);
        }

        void ShowMarkers(string queryFill, string queryShow)
        {
            DataTable tap = new DataTable();
            new MySqlDataAdapter(queryFill, con).Fill(tap);
            huizen = tap.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Wijk")).ToList();

            foreach (var huis in huizen)
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(queryShow, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow i in dt.Rows)
                {
                    string MyDoubleLong = i[1].ToString();
                    double Long = double.Parse(MyDoubleLong);
                    string MyDoubleLat = i[2].ToString();
                    double Lat = double.Parse(MyDoubleLat);
                    CreateMarker(i[0].ToString(), Long, Lat, i[3].ToString(), i[4].ToString(), i[5].ToString());
                }
            }
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

        private void StadsGebied_Dropdown_MouseDown(object sender, MouseEventArgs e)
        {
            string query = "SELECT stadsgebied.GID , stadsgebied.Naam from stadsgebied";
            fillcombo(StadsGebied_Dropdown, query, "Naam", "GID");
            StadsGebied_Dropdown_SelectedIndexChanged(null, null);
        }

        private void StadsGebied_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(StadsGebied_Dropdown.SelectedValue.ToString(), out val);
            string query = "SELECT WID , Naam,GID from wijk WHERE GID = " + val;
            fillcombo(Wijk_dropdown, query, "Naam", "WID");
        }

        private void Managehuizen_MenuItem_Click(object sender, EventArgs e)
        {
            Addhuis.Show();
            Addhuis.MdiParent = this;
            Addhuis.Dock = DockStyle.Fill;
            panel2.Hide();
            AddData.Hide();
        }

        private void ZoekHuis_MenuItem_Click(object sender, EventArgs e)
        {
            Addhuis.Hide();
            panel2.Show();
            AddData.Hide();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void setMapPosition(string query)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string MyDoubleLong = dt.Rows[0][1].ToString();
            double Long = double.Parse(MyDoubleLong);
            string MyDoubleLat = dt.Rows[0][0].ToString();
            double Lat = double.Parse(MyDoubleLat);
            GoogleMapsControl.Position = new PointLatLng(Lat, Long);
            GoogleMapsControl.Zoom = 14.85;

        }

        public void FillPercentages()
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(@"select subcategoriecriminaliteit.Per2016 from subcategoriecriminaliteit join wijk on  subcategoriecriminaliteit.WID = wijk.WID where wijk.Naam = '" + Wijk_dropdown.Text + "'and subcategoriecriminaliteit.Naam = 'Woninginbraak' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                string WoningInbraak_percstr = dt.Rows[0][0].ToString();
                int WoningInbraak_percint = int.Parse(WoningInbraak_percstr);
               // WoningInbraak_Circle.Value = WoningInbraak_percint;
            }
        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {


            ClearPercentages(); //clears last 
            //FillPercentages(); // fills new
            //FillChart();

            if (StadsGebied_Dropdown.Text == "")
            {
                MessageBox.Show("Selecteer een Stadsgebied");
            }
            else
            {
                if (Straat_TextBox.Text != "")
                {

                    if (KoopHuur_DropDown.Text != "")
                    {
                        ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "' and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'");
                        
                        if (PrijsTot_Textbox.Text != "")
                        {
                            GoogleMapsControl.Overlays.Clear();
                            ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'and Prijs < '" + PrijsTot_Textbox.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "' and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'");
                        }

                        else
                        {
                            GoogleMapsControl.Overlays.Clear();
                            ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "' and Straat = '" + Straat_TextBox.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'");
                        }
                    }
                    else
                    {
                        GoogleMapsControl.Overlays.Clear();
                        ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'and Straat = '" + Straat_TextBox.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "' and Straat = '" + Straat_TextBox.Text + "'");
                    }
                }
                else if (KoopHuur_DropDown.Text != "")
                {
                    GoogleMapsControl.Overlays.Clear();
                    ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'and KoopHuur = '" + KoopHuur_DropDown.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "' and KoopHuur = '" + KoopHuur_DropDown.Text + "'");

                }
                else
                {
                    GoogleMapsControl.Overlays.Clear();
                    ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11169883`.`huis` where stadsgebied = '" + StadsGebied_Dropdown.Text + "' and wijk = '" + Wijk_dropdown.Text + "'");

                }
                setMapPosition("SELECT wijk.Lat,wijk.Long From sql11169883.wijk where wijk.Naam = '" + Wijk_dropdown.Text + "'");
                KoopHuur_DropDown.SelectedIndex = -1;
            }
        }

        void ClearPercentages()
        {
            //WoningInbraak_Circle.Value = 0;
            //AutoInbraak_Circle.Value = 0;
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_UI LoginUI = new Login_UI();
            LoginUI.Show();
        }

        private void ManageData_MenuItem_Click(object sender, EventArgs e)
        {
            AddData.Show();
            AddData.MdiParent = this;
            AddData.Dock = DockStyle.Fill;
            panel2.Hide();
        }

        void FillChart()
        {
            sda = new MySqlDataAdapter("select per2013,per2014,per2015,per2016 from subcategoriecriminaliteit join wijk on  subcategoriecriminaliteit.WID = wijk.WID where wijk.Naam = '" + Wijk_dropdown.Text + "'and subcategoriecriminaliteit.Naam = 'Woninginbraak'",con);
            dt = new DataTable();
            sda.Fill(dt);

            Inbraak_Chart.Series["Perc"].Points.AddXY("2013", dt.Rows[0][0].ToString());
            Inbraak_Chart.Series["Perc"].Points.AddXY("2014", dt.Rows[0][1].ToString());
            Inbraak_Chart.Series["Perc"].Points.AddXY("2015", dt.Rows[0][2].ToString());
            Inbraak_Chart.Series["Perc"].Points.AddXY("2016", dt.Rows[0][3].ToString());

        }
    }
}
