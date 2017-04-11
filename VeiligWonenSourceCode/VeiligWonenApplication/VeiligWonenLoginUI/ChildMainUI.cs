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
using System.Data.SqlClient;

namespace VeiligWonenLoginUI
{
    public partial class ChildMainUI : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        public ChildMainUI()
        {
            InitializeComponent();
        }

        private void ChildMainUI_Load(object sender, EventArgs e)
        {
            GoogleMapsControl.DragButton = MouseButtons.Left;
            GoogleMapsControl.CanDragMap = true;
            GoogleMapsControl.MapProvider = GMapProviders.GoogleMap;
            GoogleMapsControl.Position = new PointLatLng(51.927740, 4.477007);
            GoogleMapsControl.MinZoom = 0;
            GoogleMapsControl.MaxZoom = 24;
            GoogleMapsControl.Zoom = 11;

            List<string> huizen = new List<string>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBConnector.ConnectionValue("VeiligWonenDataBase")))
            {
                DataTable tap = new DataTable();
                new SqlDataAdapter(@"SELECT * FROM Huis where Stadsgebied = '" + Stadsgebied_Dropdown.Text + "' and Wijk = '" + Wijk_Dropdown.Text + "'", connection.ConnectionString).Fill(tap);
                huizen = tap.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Straat")).ToList();
            }

            foreach (var huis in huizen)
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBConnector.ConnectionValue("VeiligWonenDataBase")))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"Select Straat,Lat,Long From Huis where Wijk = '"+Wijk_Dropdown.Text+"' ",connection.ConnectionString);
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
