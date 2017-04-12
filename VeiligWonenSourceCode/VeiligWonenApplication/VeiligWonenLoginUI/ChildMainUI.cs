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
using MySql.Data.MySqlClient;

namespace VeiligWonenLoginUI
{
    public partial class ChildMainUI : Form
    {
        Child_AddHuis ChildAddHuis = new Child_AddHuis();

        MySqlConnection con = new MySqlConnection("server = sql11.freemysqlhosting.net; database=sql11168746; user=sql11168746; password=7u21Rl2GCK");

        GMarkerGoogle marker;

        GMapOverlay markerOverlay;

        List<string> huizen = new List<string>();

        public ChildMainUI()
        {
            InitializeComponent();
        }

        private void ChildMainUI_Load(object sender, EventArgs e)
        {
            GoogleMapsControl.DragButton = MouseButtons.Left;
            GoogleMapsControl.CanDragMap = true;
            GoogleMapsControl.MapProvider = GMapProviders.GoogleMap;
            GoogleMapsControl.Position = new PointLatLng(51.906582, 4.492979);
            GoogleMapsControl.MinZoom = 11;
            GoogleMapsControl.MaxZoom = 24;
            GoogleMapsControl.Zoom = 12;
            ShowMarkers("select * from huis ", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11168746`.`huis` ");


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

        private void Zoek_Button_Click(object sender, EventArgs e)
        {
            GoogleMapsControl.Overlays.Clear();

            if (Straat_TextBox.Text != "")
            {
                if (Huisnummer_TextBox.Text != "")
                {
                    ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + Stadsgebied_Dropdown.Text + "' and wijk = '" + Wijk_Dropdown.Text + "'and Straat = '" + Straat_TextBox.Text + "' and HuisNummer = '" + Huisnummer_TextBox.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11168746`.`huis` where stadsgebied = '" + Stadsgebied_Dropdown.Text + "' and wijk = '" + Wijk_Dropdown.Text + "' and Straat = '" + Straat_TextBox.Text + "'and HuisNummer = '" + Huisnummer_TextBox.Text + "'");

                }
                else
                {
                    ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + Stadsgebied_Dropdown.Text + "' and wijk = '" + Wijk_Dropdown.Text + "'and Straat = '" + Straat_TextBox.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11168746`.`huis` where stadsgebied = '" + Stadsgebied_Dropdown.Text + "' and wijk = '" + Wijk_Dropdown.Text + "' and Straat = '" + Straat_TextBox.Text + "'");

                }
            }
            else if (Huisnummer_TextBox.Text != "")
            {
                ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + Stadsgebied_Dropdown.Text + "' and wijk = '" + Wijk_Dropdown.Text + "'and HuisNummer = '" + Huisnummer_TextBox.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11168746`.`huis` where stadsgebied = '" + Stadsgebied_Dropdown.Text + "' and wijk = '" + Wijk_Dropdown.Text + "'and HuisNummer = '" + Huisnummer_TextBox.Text + "'");

            }
            else
            {
                ShowMarkers(@"SELECT * FROM huis where stadsgebied = '" + Stadsgebied_Dropdown.Text + "' and wijk = '" + Wijk_Dropdown.Text + "'", @"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`,`huis`.`HuisNummer`,`huis`.`Prijs`,`huis`.`KoopHuur` FROM `sql11168746`.`huis` where stadsgebied = '" + Stadsgebied_Dropdown.Text + "' and wijk = '" + Wijk_Dropdown.Text + "'");

            }
         

           
            setMapPosition("SELECT wijk.Lat,wijk.Long From sql11168746.wijk where wijk.Naam = '" + Wijk_Dropdown.Text + "'");

        }

        private void Stadsgebied_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(Stadsgebied_Dropdown.SelectedValue.ToString(), out val);
            string query = "SELECT WID , Naam,GID from wijk WHERE GID = " + val;
            ChildAddHuis.fillcombo(Wijk_Dropdown, query, "Naam", "WID");

        }

        private void Wijk_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ShowMarkers(string queryFill, string queryShow)
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

        private void Stadsgebied_Dropdown_MouseDown(object sender, MouseEventArgs e)
        {
            string query = "SELECT stadsgebied.GID , stadsgebied.Naam from stadsgebied";
            ChildAddHuis.fillcombo(Stadsgebied_Dropdown, query, "Naam", "GID");
            Stadsgebied_Dropdown_SelectedIndexChanged(null, null);
        }
    }
}
