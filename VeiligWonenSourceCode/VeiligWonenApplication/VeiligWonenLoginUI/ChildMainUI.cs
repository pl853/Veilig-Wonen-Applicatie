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
        MySqlConnection con = new MySqlConnection();
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        public ChildMainUI()
        {
            InitializeComponent();
        }

        private void ChildMainUI_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server = sql11.freemysqlhosting.net; database=sql11168746; user=sql11168746; password=7u21Rl2GCK";
            GoogleMapsControl.DragButton = MouseButtons.Left;
            GoogleMapsControl.CanDragMap = true;
            GoogleMapsControl.MapProvider = GMapProviders.GoogleMap;
            GoogleMapsControl.Position = new PointLatLng(51.927740, 4.477007);
            GoogleMapsControl.MinZoom = 0;
            GoogleMapsControl.MaxZoom = 24;
            GoogleMapsControl.Zoom = 11;

                List<string> huizen = new List<string>();
                DataTable tap = new DataTable();
                new MySqlDataAdapter(@"SELECT * FROM huis where Stadsgebied = '" + Stadsgebied_Dropdown.Text + "' and Wijk = '" + Wijk_Dropdown.Text + "'", con.ConnectionString).Fill(tap);
                huizen = tap.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Straat")).ToList();

            foreach (var huis in huizen)
            {
                    MySqlDataAdapter sda = new MySqlDataAdapter(@"SELECT `huis`.`Straat`,`huis`.`Lat`,`huis`.`Long`FROM `sql11168746`.`huis` where huis.wijk  = '" + Wijk_Dropdown.Text+"' ",con.ConnectionString);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    foreach (DataRow i in dt.Rows)
                    {
                        string MyDoubleLong = i[1].ToString();
                        double Long = double.Parse(MyDoubleLong);
                        string MyDoubleLat = i[2].ToString();
                        double Lat = double.Parse(MyDoubleLat);
                        CreateMarker(i[0].ToString(), Long, Lat);
                    }
            }

        }

        void CreateMarker(string name,double Latitude , double Longditute)
        {
            markerOverlay = new GMapOverlay("marker");
            marker = new GMarkerGoogle(new PointLatLng(Latitude, Longditute), GMarkerGoogleType.black_small);
            markerOverlay.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format(name + ": \n Breedte:{0} \n Lengte: {1}", Latitude, Longditute);
            GoogleMapsControl.Overlays.Add(markerOverlay);
        }


    }
}
